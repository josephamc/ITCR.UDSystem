#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Cliente:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFSOLICITUD'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: Tuesday, December 25, 2012, 4:20:02 PM
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
	/// Propósito: Clase de acceso a datos derivada para tabla 'UDGDFSOLICITUD'.
	/// </summary>
	public class cUDGDFSOLICITUDDatos : cUDGDFSOLICITUDBase
	{


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFSOLICITUDDatos() : base()
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
		///		 <LI>FKY_INSTALACION</LI>
		///		 <LI>FEC_INICIO</LI>
		///		 <LI>FEC_FIN</LI>
		///		 <LI>FEC_SOLICITUD</LI>
		///		 <LI>HRA_INICIO</LI>
		///		 <LI>HRA_FIN</LI>
		///		 <LI>NOM_ENCARGADO</LI>
		///		 <LI>NOM_INSTITUCION</LI>
		///		 <LI>COD_IDENTIFICACION</LI>
		///		 <LI>CAN_USUARIOS</LI>
		///		 <LI>FKY_TIPOSOLICITANTE</LI>
		///		 <LI>TXT_OBSERVACIONES. May be SqlString.Null</LI>
		///		 <LI>DSC_RAZONUSO</LI>
		///		 <LI>COD_TIPOSOLICITUD</LI>
		///		 <LI>TXT_CORREO</LI>
		///		 <LI>COD_ATENDIDO</LI>
		///		 <LI>TXT_USUARIOS</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>ID_SOLICITUD</LI>
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
		///		 <LI>ID_SOLICITUD</LI>
		///		 <LI>FKY_INSTALACION</LI>
		///		 <LI>FEC_INICIO</LI>
		///		 <LI>FEC_FIN</LI>
		///		 <LI>FEC_SOLICITUD</LI>
		///		 <LI>HRA_INICIO</LI>
		///		 <LI>HRA_FIN</LI>
		///		 <LI>NOM_ENCARGADO</LI>
		///		 <LI>NOM_INSTITUCION</LI>
		///		 <LI>COD_IDENTIFICACION</LI>
		///		 <LI>CAN_USUARIOS</LI>
		///		 <LI>FKY_TIPOSOLICITANTE</LI>
		///		 <LI>TXT_OBSERVACIONES. May be SqlString.Null</LI>
		///		 <LI>DSC_RAZONUSO</LI>
		///		 <LI>COD_TIPOSOLICITUD</LI>
		///		 <LI>TXT_CORREO</LI>
		///		 <LI>COD_ATENDIDO</LI>
		///		 <LI>TXT_USUARIOS</LI>
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
		///		 <LI>ID_SOLICITUD</LI>
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
		///		 <LI>ID_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		///		 <LI>ID_SOLICITUD</LI>
		///		 <LI>FKY_INSTALACION</LI>
		///		 <LI>FEC_INICIO</LI>
		///		 <LI>FEC_FIN</LI>
		///		 <LI>FEC_SOLICITUD</LI>
		///		 <LI>HRA_INICIO</LI>
		///		 <LI>HRA_FIN</LI>
		///		 <LI>NOM_ENCARGADO</LI>
		///		 <LI>NOM_INSTITUCION</LI>
		///		 <LI>COD_IDENTIFICACION</LI>
		///		 <LI>CAN_USUARIOS</LI>
		///		 <LI>FKY_TIPOSOLICITANTE</LI>
		///		 <LI>TXT_OBSERVACIONES</LI>
		///		 <LI>DSC_RAZONUSO</LI>
		///		 <LI>COD_TIPOSOLICITUD</LI>
		///		 <LI>TXT_CORREO</LI>
		///		 <LI>COD_ATENDIDO</LI>
		///		 <LI>TXT_USUARIOS</LI>
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
		///		 <LI>ID_SOLICITUD</LI>
		///		 <LI>FKY_INSTALACION</LI>
		///		 <LI>FEC_INICIO</LI>
		///		 <LI>FEC_FIN</LI>
		///		 <LI>FEC_SOLICITUD</LI>
		///		 <LI>HRA_INICIO</LI>
		///		 <LI>HRA_FIN</LI>
		///		 <LI>NOM_ENCARGADO</LI>
		///		 <LI>NOM_INSTITUCION</LI>
		///		 <LI>COD_IDENTIFICACION</LI>
		///		 <LI>CAN_USUARIOS</LI>
		///		 <LI>FKY_TIPOSOLICITANTE</LI>
		///		 <LI>TXT_OBSERVACIONES. May be SqlString.Null</LI>
		///		 <LI>DSC_RAZONUSO</LI>
		///		 <LI>COD_TIPOSOLICITUD</LI>
		///		 <LI>TXT_CORREO</LI>
		///		 <LI>COD_ATENDIDO</LI>
		///		 <LI>TXT_USUARIOS</LI>
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

        // *************************************************************************************** //
        //                            Metodos agregados                                            //
        // *************************************************************************************** //

        /// <summary>
        /// Consulta todas las solicitudes que no han sido atendidas
        /// </summary>
        /// <param name="p_atendido">Indica si la solicitud ha sido atendida o no</param>
        /// <returns>DataTable object</returns>
        public virtual DataTable ConsultarSolicitudes(Boolean p_atendido)
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_SeleccionarTodos_Con_COD_ATENDIDO]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("UDGDFSOLICITUD");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_ATENDIDO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, p_atendido));
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
                adapter.Fill(toReturn);
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_SeleccionarTodos_Con_COD_ATENDIDO' reportó el error Código: " + _codError);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFSOLICITUDDatos::ConsultarSolicitudes::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
                adapter.Dispose();
            }
        }

        /// <summary>
        /// Busca las solicitudes con el id especificado
        /// </summary>
        /// <param name="p_id">Id de la solicitud a buscar</param>
        /// <returns>DataTable object</returns>
        public virtual DataTable BuscarConId(int p_id)
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_Buscar_Con_ID]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("UDGDFSOLICITUD");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, true, 10, 0, "", DataRowVersion.Proposed, p_id));
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
                adapter.Fill(toReturn);
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_Buscar_Con_ID' reportó el error Código: " + _codError);
                }

                return toReturn;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFSOLICITUDDatos::BuscarConId::Ocurrió un error." + ex.Message, ex);
            }
            finally
            {
                if (_conexionBDEsCreadaLocal)
                {
                    // Cierra la conexión.
                    _conexionBD.Close();
                }
                cmdAEjecutar.Dispose();
                adapter.Dispose();
            }
        }

        /// <summary>
        /// Actualiza el campo COD_ATENDIDO de una solicitud especifica
        /// </summary>
        /// <param name="p_id">Id de la solicitud</param>
        /// <returns>Codigo de error</returns>
        public virtual bool ActualizarAtendidoConID(int p_id)
        {
            SqlCommand cmdAEjecutar = new SqlCommand();
            cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_Actualizar_COD_ATENDIDO]";
            cmdAEjecutar.CommandType = CommandType.StoredProcedure;

            // Usar el objeto conexión de la clase base
            cmdAEjecutar.Connection = _conexionBD;

            try
            {
                cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_SOLICITUD", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, p_id));
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
                _filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
                _codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

                if (_codError != (int)ITCRError.AllOk)
                {
                    // Genera un error.
                    throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_Actualizar_COD_ATENDIDO' reportó el error Codigo: " + _codError);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
                throw new Exception("cUDGDFSOLICITUDDatos::ActualizarAtendidoConID::Ocurrió un error." + ex.Message, ex);
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
