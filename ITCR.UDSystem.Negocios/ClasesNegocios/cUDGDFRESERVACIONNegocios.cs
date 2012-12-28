#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Cliente:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de LOGICA DE NEGOCIOS para tabla 'UDGDFRESERVACION'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: Tuesday, December 25, 2012, 4:20:01 PM
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
	/// Propósito: Clase de lógica de negocios para tabla 'UDGDFRESERVACION'.
	/// </summary>
	public class cUDGDFRESERVACIONNegocios : cUDGDFRESERVACIONDatos
	{
		#region Declaraciones de miembros de la clase
		private int				_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora;
		private string			_ID_USUARIOBitacora, _COD_SEDEBitacora;
		#endregion


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFRESERVACIONNegocios(int COD_APLICACIONBitacora, string COD_SEDEBitacora, int COD_FUNCIONALIDADBitacora, string ID_USUARIOBitacora) : base()
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
			string operacion;
			Seguridad wsseg = new Seguridad();
			try
			{
				//Construir aqui el string a guardar en la bitacora.
				operacion = "Insertar cUDGDFRESERVACION;"
					+"FEC_FECHAINICIO:"+FEC_FECHAINICIO.ToString()+";"
					+"FEC_FECHAFIN:"+FEC_FECHAFIN.ToString()+";"
					+"HRA_HORAINICIO:"+HRA_HORAINICIO.ToString()+";"
					+"HRA_HORAFIN:"+HRA_HORAFIN.ToString()+";";
				//wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora,operacion);
				return base.Insertar();
			}
			catch (Exception ex)
			{
				//Construir el string a guardar en la bitácora en caso de error.
				operacion = "Error Insertar cUDGDFRESERVACION;"+ex.Message;
                //wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.Error, _ID_USUARIOBitacora,operacion);
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
			string operacion;
			Seguridad wsseg = new Seguridad();
			try
			{
				//Construir aqui el string a guardar en la bitacora.
				operacion = "Actualizar cUDGDFRESERVACION;"
					+"ID_RESERVACION:"+ID_RESERVACION.ToString()+";"
					+"FEC_FECHAINICIO:"+FEC_FECHAINICIO.ToString()+";"
					+"FEC_FECHAFIN:"+FEC_FECHAFIN.ToString()+";"
					+"HRA_HORAINICIO:"+HRA_HORAINICIO.ToString()+";"
					+"HRA_HORAFIN:"+HRA_HORAFIN.ToString()+";";
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora,operacion);
				return base.Actualizar();
			}
			catch (Exception ex)
			{
				//Construir el string a guardar en la bitácora en caso de error.
				operacion = "Error Actualizar cUDGDFRESERVACION;"+ex.Message;
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
		///		 <LI>ID_RESERVACION</LI>
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
				operacion = "Eliminar cUDGDFRESERVACION;"
					+"ID_RESERVACION:"+ID_RESERVACION.ToString()+";";
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora,operacion);
				return base.Eliminar();
			}
			catch (Exception ex)
			{
				//Construir el string a guardar en la bitácora en caso de error.
				operacion = "Error Eliminar cUDGDFRESERVACION;"+ex.Message;
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
			try
			{
				return base.Buscar();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

        //==================================================================== //
        //                  Metodos agregados                                  //
        //==================================================================== //
        public override int ConsultarDisponibilidad(DateTime p_fecinicio, DateTime p_fecfin, DateTime p_hrainicio, DateTime p_hrafin, int p_idInstalacion)
        {
            try
            {
                return base.ConsultarDisponibilidad(p_fecinicio, p_fecfin, p_hrainicio, p_hrafin, p_idInstalacion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

	} //class
} //namespace
