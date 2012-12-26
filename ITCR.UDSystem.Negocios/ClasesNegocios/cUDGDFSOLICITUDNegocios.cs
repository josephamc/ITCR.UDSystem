#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Cliente:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de LOGICA DE NEGOCIOS para tabla 'UDGDFSOLICITUD'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: Tuesday, December 25, 2012, 4:20:02 PM
///////////////////////////////////////////////////////////////////////////
#endregion


using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using ITCR.UDSystem.Base;
using ITCR.UDSystem.Datos;
using ITCR.UDSystem.Negocios.wsSeguridad;

namespace ITCR.UDSystem.Negocios
{
	/// <summary>
	/// Propósito: Clase de lógica de negocios para tabla 'UDGDFSOLICITUD'.
	/// </summary>
	public class cUDGDFSOLICITUDNegocios : cUDGDFSOLICITUDDatos
	{
		#region Declaraciones de miembros de la clase
		private int				_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora;
		private string			_ID_USUARIOBitacora, _COD_SEDEBitacora;
		#endregion


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFSOLICITUDNegocios(int COD_APLICACIONBitacora, string COD_SEDEBitacora, int COD_FUNCIONALIDADBitacora, string ID_USUARIOBitacora) : base()
		{
			//asignacion de las propiedades privadas para manejo de bitacoras
			_COD_APLICACIONBitacora = COD_APLICACIONBitacora;
			_COD_SEDEBitacora = COD_SEDEBitacora;
			_COD_FUNCIONALIDADBitacora = COD_FUNCIONALIDADBitacora;
			_ID_USUARIOBitacora = ID_USUARIOBitacora;
		}


		/// <summary>
		/// Propósito: Método Insertar de la clase de negocios. Este método inserta una fila nueva en la base de datos.
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
			string operacion;
			Seguridad wsseg = new Seguridad();
			try
			{
				//Construir aqui el string a guardar en la bitacora.
				operacion = "Insertar cUDGDFSOLICITUD;"
					+"FKY_INSTALACION:"+FKY_INSTALACION.ToString()+";"
					+"FEC_INICIO:"+FEC_INICIO.ToString()+";"
					+"FEC_FIN:"+FEC_FIN.ToString()+";"
					+"FEC_SOLICITUD:"+FEC_SOLICITUD.ToString()+";"
					+"HRA_INICIO:"+HRA_INICIO.ToString()+";"
					+"HRA_FIN:"+HRA_FIN.ToString()+";"
					+"NOM_ENCARGADO:"+NOM_ENCARGADO.ToString()+";"
					+"NOM_INSTITUCION:"+NOM_INSTITUCION.ToString()+";"
					+"COD_IDENTIFICACION:"+COD_IDENTIFICACION.ToString()+";"
					+"CAN_USUARIOS:"+CAN_USUARIOS.ToString()+";"
					+"FKY_TIPOSOLICITANTE:"+FKY_TIPOSOLICITANTE.ToString()+";"
					+"TXT_OBSERVACIONES:"+TXT_OBSERVACIONES.ToString()+";"
					+"DSC_RAZONUSO:"+DSC_RAZONUSO.ToString()+";"
					+"COD_TIPOSOLICITUD:"+COD_TIPOSOLICITUD.ToString()+";"
					+"TXT_CORREO:"+TXT_CORREO.ToString()+";"
					+"COD_ATENDIDO:"+COD_ATENDIDO.ToString()+";"
					+"TXT_USUARIOS:"+TXT_USUARIOS.ToString()+";";
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora,operacion);
				return base.Insertar();
			}
			catch (Exception ex)
			{
				//Construir el string a guardar en la bitácora en caso de error.
				operacion = "Error Insertar cUDGDFSOLICITUD;"+ex.Message;
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.Error, _ID_USUARIOBitacora,operacion);
				throw ex;
			}
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
			string operacion;
			Seguridad wsseg = new Seguridad();
			try
			{
				//Construir aqui el string a guardar en la bitacora.
				operacion = "Actualizar cUDGDFSOLICITUD;"
					+"ID_SOLICITUD:"+ID_SOLICITUD.ToString()+";"
					+"FKY_INSTALACION:"+FKY_INSTALACION.ToString()+";"
					+"FEC_INICIO:"+FEC_INICIO.ToString()+";"
					+"FEC_FIN:"+FEC_FIN.ToString()+";"
					+"FEC_SOLICITUD:"+FEC_SOLICITUD.ToString()+";"
					+"HRA_INICIO:"+HRA_INICIO.ToString()+";"
					+"HRA_FIN:"+HRA_FIN.ToString()+";"
					+"NOM_ENCARGADO:"+NOM_ENCARGADO.ToString()+";"
					+"NOM_INSTITUCION:"+NOM_INSTITUCION.ToString()+";"
					+"COD_IDENTIFICACION:"+COD_IDENTIFICACION.ToString()+";"
					+"CAN_USUARIOS:"+CAN_USUARIOS.ToString()+";"
					+"FKY_TIPOSOLICITANTE:"+FKY_TIPOSOLICITANTE.ToString()+";"
					+"TXT_OBSERVACIONES:"+TXT_OBSERVACIONES.ToString()+";"
					+"DSC_RAZONUSO:"+DSC_RAZONUSO.ToString()+";"
					+"COD_TIPOSOLICITUD:"+COD_TIPOSOLICITUD.ToString()+";"
					+"TXT_CORREO:"+TXT_CORREO.ToString()+";"
					+"COD_ATENDIDO:"+COD_ATENDIDO.ToString()+";"
					+"TXT_USUARIOS:"+TXT_USUARIOS.ToString()+";";
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora,operacion);
				return base.Actualizar();
			}
			catch (Exception ex)
			{
				//Construir el string a guardar en la bitácora en caso de error.
				operacion = "Error Actualizar cUDGDFSOLICITUD;"+ex.Message;
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.Error, _ID_USUARIOBitacora,operacion);
				throw ex;
			}
		}


		/// <summary>
		/// Propósito: Método Eliminar de lógica de negocios. Borra una fila en la base de datos, basado en la llave primaria.
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
			string operacion;
			Seguridad wsseg = new Seguridad();
			try
			{
				//Construir aqui el string a guardar en la bitacora.
				operacion = "Eliminar cUDGDFSOLICITUD;"
					+"ID_SOLICITUD:"+ID_SOLICITUD.ToString()+";";
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora,operacion);
				return base.Eliminar();
			}
			catch (Exception ex)
			{
				//Construir el string a guardar en la bitácora en caso de error.
				operacion = "Error Eliminar cUDGDFSOLICITUD;"+ex.Message;
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.Error, _ID_USUARIOBitacora,operacion);
				throw ex;
			}
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
			try
			{
				return base.SeleccionarUno();
			}
			catch (Exception ex)
			{
				throw ex;
			}
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
			try
			{
				return base.SeleccionarTodos();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


		/// <summary>
		/// Propósito: Método Buscar. Este método va a Hacer un SELECT LIKE de tabla.
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
			try
			{
				return base.Buscar();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        // *************************************************************************************** //
        //                            Metodos agregados                                            //
        // *************************************************************************************** //

        /// <summary>
        /// Consulta todas las solicitudes que no han sido atendidas
        /// </summary>
        /// <param name="p_atendido">Indica si la solicitud ha sido atendida o no</param>
        /// <returns>DataTable object</returns>
        public override DataTable ConsultarSolicitudes(Boolean p_atendido)
        {
            try
            {
                return base.ConsultarSolicitudes(p_atendido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Busca las solicitudes con el id especificado
        /// </summary>
        /// <param name="p_id">Id de la solicitud a buscar</param>
        /// <returns>DataTable object</returns>
        public override DataTable BuscarConId(int p_id)
        {
            try
            {
                return base.BuscarConId(p_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Actualiza el campo COD_ATENDIDO de una solicitud especifica
        /// </summary>
        /// <param name="p_id">Id de la solicitud</param>
        /// <returns>Codigo de error</returns>
        public override bool ActualizarAtendidoConID(int p_id)
        {
            try
            {
                return base.ActualizarAtendidoConID(p_id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
	} //class
} //namespace
