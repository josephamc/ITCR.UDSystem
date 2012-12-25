#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Cliente:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de LOGICA DE NEGOCIOS para tabla 'UDGDFCURSO'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: sábado, 22 de diciembre de 2012, 09:53:59 a.m.
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
	/// Propósito: Clase de lógica de negocios para tabla 'UDGDFCURSO'.
	/// </summary>
	public class cUDGDFCURSONegocios : cUDGDFCURSODatos
	{
		#region Declaraciones de miembros de la clase
		private int				_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora;
		private string			_ID_USUARIOBitacora, _COD_SEDEBitacora;
		#endregion


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFCURSONegocios(int COD_APLICACIONBitacora, string COD_SEDEBitacora, int COD_FUNCIONALIDADBitacora, string ID_USUARIOBitacora) : base()
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
		///		 <LI>NOM_PROFESOR</LI>
		///		 <LI>COD_LUNES</LI>
		///		 <LI>COD_MARTES</LI>
		///		 <LI>COD_MIERCOLES</LI>
		///		 <LI>COD_JUEVES</LI>
		///		 <LI>COD_VIERNES</LI>
		///		 <LI>FKY_CALENDARIO</LI>
		///		 <LI>FKY_RESERVACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>ID_CURSO</LI>
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
				operacion = "Insertar cUDGDFCURSO;"
					+"NOM_PROFESOR:"+NOM_PROFESOR.ToString()+";"
					+"COD_LUNES:"+COD_LUNES.ToString()+";"
					+"COD_MARTES:"+COD_MARTES.ToString()+";"
					+"COD_MIERCOLES:"+COD_MIERCOLES.ToString()+";"
					+"COD_JUEVES:"+COD_JUEVES.ToString()+";"
					+"COD_VIERNES:"+COD_VIERNES.ToString()+";"
					+"FKY_CALENDARIO:"+FKY_CALENDARIO.ToString()+";"
					+"FKY_RESERVACION:"+FKY_RESERVACION.ToString()+";";
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora,operacion);
				return base.Insertar();
			}
			catch (Exception ex)
			{
				//Construir el string a guardar en la bitácora en caso de error.
				operacion = "Error Insertar cUDGDFCURSO;"+ex.Message;
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
		///		 <LI>ID_CURSO</LI>
		///		 <LI>NOM_PROFESOR</LI>
		///		 <LI>COD_LUNES</LI>
		///		 <LI>COD_MARTES</LI>
		///		 <LI>COD_MIERCOLES</LI>
		///		 <LI>COD_JUEVES</LI>
		///		 <LI>COD_VIERNES</LI>
		///		 <LI>FKY_CALENDARIO</LI>
		///		 <LI>FKY_RESERVACION</LI>
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
				operacion = "Actualizar cUDGDFCURSO;"
					+"ID_CURSO:"+ID_CURSO.ToString()+";"
					+"NOM_PROFESOR:"+NOM_PROFESOR.ToString()+";"
					+"COD_LUNES:"+COD_LUNES.ToString()+";"
					+"COD_MARTES:"+COD_MARTES.ToString()+";"
					+"COD_MIERCOLES:"+COD_MIERCOLES.ToString()+";"
					+"COD_JUEVES:"+COD_JUEVES.ToString()+";"
					+"COD_VIERNES:"+COD_VIERNES.ToString()+";"
					+"FKY_CALENDARIO:"+FKY_CALENDARIO.ToString()+";"
					+"FKY_RESERVACION:"+FKY_RESERVACION.ToString()+";";
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora,operacion);
				return base.Actualizar();
			}
			catch (Exception ex)
			{
				//Construir el string a guardar en la bitácora en caso de error.
				operacion = "Error Actualizar cUDGDFCURSO;"+ex.Message;
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
		///		 <LI>ID_CURSO</LI>
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
				operacion = "Eliminar cUDGDFCURSO;"
					+"ID_CURSO:"+ID_CURSO.ToString()+";";
				wsseg.BitacoraRegistrarUso(_COD_APLICACIONBitacora, _COD_FUNCIONALIDADBitacora, _COD_SEDEBitacora, eTipoEventoBitacora.UsoFuncionalidad, _ID_USUARIOBitacora,operacion);
				return base.Eliminar();
			}
			catch (Exception ex)
			{
				//Construir el string a guardar en la bitácora en caso de error.
				operacion = "Error Eliminar cUDGDFCURSO;"+ex.Message;
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
		///		 <LI>ID_CURSO</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		///		 <LI>ID_CURSO</LI>
		///		 <LI>NOM_PROFESOR</LI>
		///		 <LI>COD_LUNES</LI>
		///		 <LI>COD_MARTES</LI>
		///		 <LI>COD_MIERCOLES</LI>
		///		 <LI>COD_JUEVES</LI>
		///		 <LI>COD_VIERNES</LI>
		///		 <LI>FKY_CALENDARIO</LI>
		///		 <LI>FKY_RESERVACION</LI>
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
		///		 <LI>ID_CURSO</LI>
		///		 <LI>NOM_PROFESOR</LI>
		///		 <LI>COD_LUNES</LI>
		///		 <LI>COD_MARTES</LI>
		///		 <LI>COD_MIERCOLES</LI>
		///		 <LI>COD_JUEVES</LI>
		///		 <LI>COD_VIERNES</LI>
		///		 <LI>FKY_CALENDARIO</LI>
		///		 <LI>FKY_RESERVACION</LI>
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
	} //class
} //namespace
