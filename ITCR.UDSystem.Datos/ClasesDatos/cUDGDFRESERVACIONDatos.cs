#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Cliente:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFRESERVACION'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: Tuesday, December 25, 2012, 4:20:01 PM
// Dado que esta clase implementa IDispose, las clases derivadas no deben hacerlo.
///////////////////////////////////////////////////////////////////////////
#endregion


using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using ITCR.UDSystem.Base;

namespace ITCR.UDSystem.Datos
{
	/// <summary>
	/// Propósito: Clase de acceso a datos derivada para tabla 'UDGDFRESERVACION'.
	/// </summary>
	public class cUDGDFRESERVACIONDatos : cUDGDFRESERVACIONBase
	{


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFRESERVACIONDatos() : base()
		{
			// Agregar código aquí.
		}


		/// <summary>
		/// Propósito: Método Insertar. Este método inserta una fila nueva en la base de datos.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FEC_FECHAINICIO</LI>
		///		 <LI>FEC_FECHAFIN</LI>
		///		 <LI>HRA_HORAINICIO</LI>
		///		 <LI>HRA_HORAFIN</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Insertar()
		{
			return base.Insertar();
		}


		/// <summary>
		/// Propósito: Método Update. Actualiza una fila existente en la base de datos.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		///		 <LI>FEC_FECHAINICIO</LI>
		///		 <LI>FEC_FECHAFIN</LI>
		///		 <LI>HRA_HORAINICIO</LI>
		///		 <LI>HRA_HORAFIN</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Actualizar()
		{
			return base.Actualizar();
		}


		/// <summary>
		/// Propósito: Método Eliminar. Borra una fila en la base de datos, basado en la llave primaria.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Eliminar()
		{
			return base.Eliminar();
		}


		/// <summary>
		/// Propósito: Método SELECT. Este método hace Select de una fila existente en la base de datos, basado en la llave primaria.
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		///		 <LI>ID_RESERVACION</LI>
		///		 <LI>FEC_FECHAINICIO</LI>
		///		 <LI>FEC_FECHAFIN</LI>
		///		 <LI>HRA_HORAINICIO</LI>
		///		 <LI>HRA_HORAFIN</LI>
		/// </UL>
		/// Llena todas las propiedades que corresponden al campo en tabla con el valor de la fila seleccionada.
		/// </remarks>
		public override DataTable SeleccionarUno()
		{
			return base.SeleccionarUno();
		}


		/// <summary>
		/// Propósito: Método SeleccionarTodos. Este método va a Hacer un SELECT All de tabla.
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable SeleccionarTodos()
		{
			return base.SeleccionarTodos();
		}


		/// <summary>
		/// Propósito: Método Buscar. Este método va a Hacer un SELECT de tabla.
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>ID_RESERVACION</LI>
		///		 <LI>FEC_FECHAINICIO</LI>
		///		 <LI>FEC_FECHAFIN</LI>
		///		 <LI>HRA_HORAINICIO</LI>
		///		 <LI>HRA_HORAFIN</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable Buscar()
		{
			//TODO: agregar % para busqueda de campos string (varchar, etc.) con LIKE (el procedimiento ya lo hace), así:
			//if (!base.DescripcionCF.IsNull) {
				//    base.DescripcionCF = "{0}" + base.DescripcionCF + "{0}"; }
			return base.Buscar();
		}

        //============================================================================================
        //                              Store Procedures agregados
        //============================================================================================
        public virtual int ConsultarDisponibilidad(DateTime p_fecinicio, DateTime p_fecfin, DateTime p_hrainicio, DateTime p_hrafin, int p_idInstalacion)
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFARESERVACION_ConsultarDisponibilidad]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            int toReturn = -1000;
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_INSTALACION", SqlDbType.VarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, p_idInstalacion));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FECHAINICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, p_fecinicio));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FECHAFIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, p_fecfin));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_HORAINICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, p_hrainicio));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_HORAFIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, p_hrafin));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodDisponible", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, toReturn));
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));
                if (_conexionBDEsCreadaLocal)
                {
                    // Abre una conexión.
                    _conexionBD.Open();
                }
                else
                {
                    if (_conexionBDProvider.IsTransactionPending)
                    {
                        cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
                    }
                }

                // Ejecuta la consulta.
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFARESERVACION_ConsultarDisponibilidad' reportó el error Código: " + _codError);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFRESERVACIONDatos::ConsultarDisponibilidad::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
            }
        }
	} //class
} //namespace
