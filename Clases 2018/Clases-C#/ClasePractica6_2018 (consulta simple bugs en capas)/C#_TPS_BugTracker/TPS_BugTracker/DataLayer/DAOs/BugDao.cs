

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using TPS_BugTracker.BusinessLayer.Entities;
using System.Data;

namespace TPS_BugTracker.DataLayer.DAOs
{
    public class BugDao
    {
        public Bug getBugById(int id)
        {
            string sql = "SELECT " + 
                " b.id_bug," + 
                " b.titulo," + 
                " b.descripcion," + 
                " b.id_producto," + 
                " b.id_prioridad," +
                " b.fecha_alta," + 
                " b.id_criticidad," + 
                " pro.nombre," + 
                " pri.n_prioridad," + 
                " cri.n_criticidad," +
                " e.n_estado, FROM bugs b, Productos pro, Prioridades pri, Criticidades cri, Estados e " + 
                " WHERE b.id_producto = pro.id_producto" + 
                " AND b.id_prioridad = pri.id_prioridad" +
                " AND b.id_criticidad = cri.id_criticidad AND b.id = "+id; 

            return mapBug(BDHelper.getBDHelper().ConsultaSQL(sql).Rows[0]);
        }

        public IList<Bug> getBugByFilters(List<object> parametros)
        {
            List<Bug> lst = new List<Bug>();

            string sql = "SELECT " +
                " b.id_bug," +
                " b.titulo," +
                " b.descripcion," +
                " b.id_producto," +
                " b.id_prioridad," +
                " b.fecha_alta," +
                " b.id_criticidad," +
                " pro.nombre," +
                " pri.n_prioridad," +
                " cri.n_criticidad," +
                " e.n_estado FROM bugs b, Productos pro, Prioridades pri, Criticidades cri, Estados e " +
                " WHERE b.id_producto = pro.id_producto" +
                " AND b.id_prioridad = pri.id_prioridad" +
                " AND b.id_criticidad = cri.id_criticidad"+
                " AND b.id_estado = e.id_estado"; 

            // Validamos filtro de fechas
            if (parametros[0] != null && parametros[1] != null)
                sql += " AND (b.fecha_alta>=@param1 AND b.fecha_alta<=@param2) ";
            // Validamos filtro prioridad
            if (parametros[2] != null)
                sql += " AND b.id_prioridad=@param3 ";
            // Validamos filtro criticidad
            if (parametros[3] != null)
                sql += " AND b.id_criticidad=@param4 ";
            // Validamos filtro producto
            if (parametros[4] != null)
                sql += " AND b.id_producto=@param5 ";

            if (parametros[5] != null)
                sql += " AND b.estado=@param6 ";
            // Con el mismo criterio validamos filtro asignado_a
            if (parametros[6] != null)
                sql += " AND b.asignado_a=@param7 ";
            sql += " ORDER BY b.fecha_alta DESC ";

            foreach (DataRow row in BDHelper.getBDHelper().ConsultaSQLConParametros(sql, parametros).Rows)
                lst.Add(mapSmallBug(row));

            return lst;
        }





        private Bug mapSmallBug(DataRow row)
        {
            Bug oBug = new Bug();

            oBug.id_bug = Convert.ToInt32(row["id_bug"].ToString());
            oBug.titulo = row["titulo"].ToString();
            oBug.fecha_alta = Convert.ToDateTime(row["fecha_alta"].ToString());
            oBug.n_producto = row["nombre"].ToString();
            oBug.estado = row["n_estado"].ToString();
            oBug.n_prioridad = row["n_prioridad"].ToString();
            oBug.n_criticidad = row["n_criticidad"].ToString();

            return oBug;
        }

        private Bug mapBug(DataRow row)
        {
            Bug oBug = new Bug();
            string sql;
            
            oBug.id_bug = Convert.ToInt32(row["id_bug"].ToString());
            oBug.titulo = row["titulo"].ToString();
            oBug.descripcion = row["descripcion"].ToString();
            oBug.fecha_alta = Convert.ToDateTime(row["fecha_alta"].ToString());
            oBug.id_producto = Convert.ToInt32(row["id_producto"].ToString());
            oBug.id_prioridad = Convert.ToInt32(row["id_prioridad"].ToString());
            oBug.id_criticidad = Convert.ToInt32(row["id_criticidad"].ToString());
            oBug.n_producto = row["nombre"].ToString();
            oBug.n_criticidad = row["n_criticidad"].ToString();
            oBug.estado = row["n_estado"].ToString();

            sql = "";

            return oBug;
        }
    }

}