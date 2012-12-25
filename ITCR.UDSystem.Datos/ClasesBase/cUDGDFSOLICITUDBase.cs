#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Empresa:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFSOLICITUD'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: Tuesday, December 25, 2012, 1:17:21 PM
// Dado que esta clase implementa IDispose, las clases derivadas no deben hacerlo.
///////////////////////////////////////////////////////////////////////////
#endregion


using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
//using Microsoft.SqlServer.Types;  //usarlo cuando hay tipos Geometry, Geography, HierarchiId. Está en C:\Program Files\Microsoft SQL Server\100\SDK\Assemblies\Microsoft.SqlServer.Types.dll

namespace ITCR.UDSystem.Base
{
	/// <summary>
	/// Propósito: Clase de acceso a datos para tabla 'UDGDFSOLICITUD'.
	/// </summary>
	public class cUDGDFSOLICITUDBase : cBDInteraccionBase
	{
		#region Declaraciones de miembros de la clase
			private SqlBoolean		_cOD_ATENDIDO;
			private SqlDateTime		_fEC_INICIO, _fEC_FIN, _fEC_SOLICITUD;
			private SqlInt32		_fKY_TIPOSOLICITANTE, _fKY_TIPOSOLICITANTEOld, _cAN_USUARIOS, _iD_SOLICITUD, _fKY_INSTALACION, _fKY_INSTALACIONOld;
			private SqlDateTime		_hRA_INICIO, _hRA_FIN;
			private SqlString		_nOM_ENCARGADO, _tXT_CORREO, _cOD_IDENTIFICACION, _tXT_OBSERVACIONES, _dSC_RAZONUSO, _cOD_TIPOSOLICITUD, _nOM_INSTITUCION;
		#endregion


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFSOLICITUDBase()
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
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>ID_SOLICITUD</LI>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Insertar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_Insertar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_INICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_INICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_FIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_SOLICITUD", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_INICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_INICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_FIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_FIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_ENCARGADO", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_ENCARGADO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_INSTITUCION", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_INSTITUCION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sCOD_IDENTIFICACION", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_IDENTIFICACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCAN_USUARIOS", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _cAN_USUARIOS));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_TIPOSOLICITANTE", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_TIPOSOLICITANTE));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_OBSERVACIONES", SqlDbType.VarChar, 300, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _tXT_OBSERVACIONES));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_RAZONUSO", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_RAZONUSO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sCOD_TIPOSOLICITUD", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_TIPOSOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_CORREO", SqlDbType.VarChar, 75, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_CORREO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_ATENDIDO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_ATENDIDO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _iD_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_iD_SOLICITUD = Int32.Parse(cmdAEjecutar.Parameters["@iID_SOLICITUD"].Value.ToString());
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_Insertar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::Insertar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
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
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Actualizar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_Actualizar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_INICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_INICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_FIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_SOLICITUD", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_INICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_INICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_FIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_FIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_ENCARGADO", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_ENCARGADO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_INSTITUCION", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_INSTITUCION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sCOD_IDENTIFICACION", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_IDENTIFICACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCAN_USUARIOS", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _cAN_USUARIOS));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_TIPOSOLICITANTE", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_TIPOSOLICITANTE));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_OBSERVACIONES", SqlDbType.VarChar, 300, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _tXT_OBSERVACIONES));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_RAZONUSO", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_RAZONUSO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sCOD_TIPOSOLICITUD", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_TIPOSOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_CORREO", SqlDbType.VarChar, 75, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_CORREO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_ATENDIDO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_ATENDIDO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_Actualizar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::Actualizar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método Update para actualizar una o más filas utilizando la llave foránea 'FKY_INSTALACION.
		/// Este método actualiza una o más filas existentes en la base de datos, actualiza el campo 'FKY_INSTALACION' en
		/// todas las filas que tienen ese valor para este campo con el valor 'FKY_INSTALACIONanterior 
		/// con el valor colocado en la propiedad 'FKY_INSTALACION'.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_INSTALACION</LI>
		///		 <LI>FKY_INSTALACIONOld</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public bool ActualizarTodos_Con_FKY_INSTALACION_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_ActualizarTodos_Con_FKY_INSTALACION_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_INSTALACIONOld", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_INSTALACIONOld));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento almacenado 'pr_UDGDFSOLICITUD_ActualizarTodos_Con_FKY_INSTALACION_FK' reportó el error Código: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::ActualizarTodos_Con_FKY_INSTALACION_FK::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método Update para actualizar una o más filas utilizando la llave foránea 'FKY_TIPOSOLICITANTE.
		/// Este método actualiza una o más filas existentes en la base de datos, actualiza el campo 'FKY_TIPOSOLICITANTE' en
		/// todas las filas que tienen ese valor para este campo con el valor 'FKY_TIPOSOLICITANTEanterior 
		/// con el valor colocado en la propiedad 'FKY_TIPOSOLICITANTE'.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_TIPOSOLICITANTE</LI>
		///		 <LI>FKY_TIPOSOLICITANTEOld</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public bool ActualizarTodos_Con_FKY_TIPOSOLICITANTE_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_ActualizarTodos_Con_FKY_TIPOSOLICITANTE_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_TIPOSOLICITANTE", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_TIPOSOLICITANTE));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_TIPOSOLICITANTEOld", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_TIPOSOLICITANTEOld));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento almacenado 'pr_UDGDFSOLICITUD_ActualizarTodos_Con_FKY_TIPOSOLICITANTE_FK' reportó el error Código: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::ActualizarTodos_Con_FKY_TIPOSOLICITANTE_FK::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
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
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_Eliminar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_Eliminar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::Eliminar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método Eliminar para una llave primaria. Este método va a borrar una o más filas en la base de datos, basado en la llave primaria 'FKY_INSTALACION'
		/// </summary>
		/// <returns>True si tuvo éxito, false otherwise. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_INSTALACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public bool EliminarTodo_Con_FKY_INSTALACION_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_EliminarTodo_Con_FKY_INSTALACION_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento almacenado 'pr_UDGDFSOLICITUD_EliminarTodo_Con_FKY_INSTALACION_FK' reportó el error Código: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::EliminarTodo_Con_FKY_INSTALACION_FK::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método Eliminar para una llave primaria. Este método va a borrar una o más filas en la base de datos, basado en la llave primaria 'FKY_TIPOSOLICITANTE'
		/// </summary>
		/// <returns>True si tuvo éxito, false otherwise. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_TIPOSOLICITANTE</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public bool EliminarTodo_Con_FKY_TIPOSOLICITANTE_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_EliminarTodo_Con_FKY_TIPOSOLICITANTE_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_TIPOSOLICITANTE", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_TIPOSOLICITANTE));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				_filasAfectadas = cmdAEjecutar.ExecuteNonQuery();
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento almacenado 'pr_UDGDFSOLICITUD_EliminarTodo_Con_FKY_TIPOSOLICITANTE_FK' reportó el error Código: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::EliminarTodo_Con_FKY_TIPOSOLICITANTE_FK::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
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
		/// </UL>
		/// Llena todas las propiedades que corresponden al campo en tabla con el valor de la fila seleccionada.
		/// </remarks>
		public override DataTable SeleccionarUno()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_SeleccionarUno]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFSOLICITUD");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_SeleccionarUno' reportó el error Código: " + _codError);
				}

				if(toReturn.Rows.Count > 0)
				{
					_iD_SOLICITUD = (Int32)toReturn.Rows[0]["ID_SOLICITUD"];
					_fKY_INSTALACION = (Int32)toReturn.Rows[0]["FKY_INSTALACION"];
					_fEC_INICIO = (DateTime)toReturn.Rows[0]["FEC_INICIO"];
					_fEC_FIN = (DateTime)toReturn.Rows[0]["FEC_FIN"];
					_fEC_SOLICITUD = (DateTime)toReturn.Rows[0]["FEC_SOLICITUD"];
					_hRA_INICIO = (DateTime)toReturn.Rows[0]["HRA_INICIO"];
					_hRA_FIN = (DateTime)toReturn.Rows[0]["HRA_FIN"];
					_nOM_ENCARGADO = (string)toReturn.Rows[0]["NOM_ENCARGADO"];
					_nOM_INSTITUCION = (string)toReturn.Rows[0]["NOM_INSTITUCION"];
					_cOD_IDENTIFICACION = (string)toReturn.Rows[0]["COD_IDENTIFICACION"];
					_cAN_USUARIOS = (Int32)toReturn.Rows[0]["CAN_USUARIOS"];
					_fKY_TIPOSOLICITANTE = (Int32)toReturn.Rows[0]["FKY_TIPOSOLICITANTE"];
					_tXT_OBSERVACIONES = toReturn.Rows[0]["TXT_OBSERVACIONES"] == System.DBNull.Value ? SqlString.Null : (string)toReturn.Rows[0]["TXT_OBSERVACIONES"];
					_dSC_RAZONUSO = (string)toReturn.Rows[0]["DSC_RAZONUSO"];
					_cOD_TIPOSOLICITUD = (string)toReturn.Rows[0]["COD_TIPOSOLICITUD"];
					_tXT_CORREO = (string)toReturn.Rows[0]["TXT_CORREO"];
					_cOD_ATENDIDO = (bool)toReturn.Rows[0]["COD_ATENDIDO"];
				}
				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::SeleccionarUno::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
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
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_SeleccionarTodos]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFSOLICITUD");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_SeleccionarTodos' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::SeleccionarTodos::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método SELECT para una llave primaria. Este método hace Select de una o más filas de la base de datos, basado en la llave primaria 'FKY_INSTALACION'
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_INSTALACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public DataTable SeleccionarTodos_Con_FKY_INSTALACION_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_SeleccionarTodos_Con_FKY_INSTALACION_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFSOLICITUD");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_SeleccionarTodos_Con_FKY_INSTALACION_FK' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch(Exception ex)
			{
				// Ocurrió un error. Le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::SeleccionarTodos_Con_FKY_INSTALACION_FK::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método SELECT para una llave primaria. Este método hace Select de una o más filas de la base de datos, basado en la llave primaria 'FKY_TIPOSOLICITANTE'
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_TIPOSOLICITANTE</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public DataTable SeleccionarTodos_Con_FKY_TIPOSOLICITANTE_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_SeleccionarTodos_Con_FKY_TIPOSOLICITANTE_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFSOLICITUD");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_TIPOSOLICITANTE", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_TIPOSOLICITANTE));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_SeleccionarTodos_Con_FKY_TIPOSOLICITANTE_FK' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch(Exception ex)
			{
				// Ocurrió un error. Le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::SeleccionarTodos_Con_FKY_TIPOSOLICITANTE_FK::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
			}
		}


		/// <summary>
		/// Propósito: Método Buscar. Este método hace una busqueda de acuerdo con todos los campos de la tabla.
		/// </summary>
		/// <returns>DataTable si tuvo éxito, sino genera una Exception. </returns>
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
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable Buscar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFSOLICITUD_Buscar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFSOLICITUD");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_INSTALACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_INSTALACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_INICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_INICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_FIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_FIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@daFEC_SOLICITUD", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _fEC_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_INICIO", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_INICIO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@tiHRA_FIN", SqlDbType.DateTime, 3, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _hRA_FIN));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_ENCARGADO", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_ENCARGADO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sNOM_INSTITUCION", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _nOM_INSTITUCION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sCOD_IDENTIFICACION", SqlDbType.VarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_IDENTIFICACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCAN_USUARIOS", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _cAN_USUARIOS));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_TIPOSOLICITANTE", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_TIPOSOLICITANTE));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_OBSERVACIONES", SqlDbType.VarChar, 300, ParameterDirection.Input, true, 0, 0, "", DataRowVersion.Proposed, _tXT_OBSERVACIONES));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sDSC_RAZONUSO", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _dSC_RAZONUSO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sCOD_TIPOSOLICITUD", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_TIPOSOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_CORREO", SqlDbType.VarChar, 75, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_CORREO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@bCOD_ATENDIDO", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _cOD_ATENDIDO));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iCodError", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _codError));

				if(_conexionBDEsCreadaLocal)
				{
					// Abre una conexión.
					_conexionBD.Open();
				}
				else
				{
					if(_conexionBDProvider.IsTransactionPending)
					{
						cmdAEjecutar.Transaction = _conexionBDProvider.CurrentTransaction;
					}
				}

				// Ejecuta la consulta.
				adapter.Fill(toReturn);
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFSOLICITUD_Buscar' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFSOLICITUDBase::Buscar::Ocurrió un error." + ex.Message, ex);
			}
			finally
			{
				if(_conexionBDEsCreadaLocal)
				{
					// Cierra la conexión.
					_conexionBD.Close();
				}
				cmdAEjecutar.Dispose();
				adapter.Dispose();
			}
		}


		#region Declaraciones de propiedades de la clase
		public SqlInt32 ID_SOLICITUD
		{
			get
			{
				return _iD_SOLICITUD;
			}
			set
			{
				SqlInt32 iD_SOLICITUDTmp = (SqlInt32)value;
				if(iD_SOLICITUDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_SOLICITUD", "ID_SOLICITUD can't be NULL");
				}
				_iD_SOLICITUD = value;
			}
		}


		public SqlInt32 FKY_INSTALACION
		{
			get
			{
				return _fKY_INSTALACION;
			}
			set
			{
				SqlInt32 fKY_INSTALACIONTmp = (SqlInt32)value;
				if(fKY_INSTALACIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FKY_INSTALACION", "FKY_INSTALACION can't be NULL");
				}
				_fKY_INSTALACION = value;
			}
		}
		public SqlInt32 FKY_INSTALACIONOld
		{
			get
			{
				return _fKY_INSTALACIONOld;
			}
			set
			{
				SqlInt32 fKY_INSTALACIONOldTmp = (SqlInt32)value;
				if(fKY_INSTALACIONOldTmp.IsNull )
				{
					throw new ArgumentOutOfRangeException("FKY_INSTALACIONOld", "FKY_INSTALACIONOld can't be NULL");
				}
				_fKY_INSTALACIONOld = value;
			}
		}


		public SqlDateTime FEC_INICIO
		{
			get
			{
				return _fEC_INICIO;
			}
			set
			{
				SqlDateTime fEC_INICIOTmp = (SqlDateTime)value;
				if(fEC_INICIOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FEC_INICIO", "FEC_INICIO can't be NULL");
				}
				_fEC_INICIO = value;
			}
		}


		public SqlDateTime FEC_FIN
		{
			get
			{
				return _fEC_FIN;
			}
			set
			{
				SqlDateTime fEC_FINTmp = (SqlDateTime)value;
				if(fEC_FINTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FEC_FIN", "FEC_FIN can't be NULL");
				}
				_fEC_FIN = value;
			}
		}


		public SqlDateTime FEC_SOLICITUD
		{
			get
			{
				return _fEC_SOLICITUD;
			}
			set
			{
				SqlDateTime fEC_SOLICITUDTmp = (SqlDateTime)value;
				if(fEC_SOLICITUDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FEC_SOLICITUD", "FEC_SOLICITUD can't be NULL");
				}
				_fEC_SOLICITUD = value;
			}
		}


		public SqlDateTime HRA_INICIO
		{
			get
			{
				return _hRA_INICIO;
			}
			set
			{
				SqlDateTime hRA_INICIOTmp = (SqlDateTime)value;
				if(hRA_INICIOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("HRA_INICIO", "HRA_INICIO can't be NULL");
				}
				_hRA_INICIO = value;
			}
		}


		public SqlDateTime HRA_FIN
		{
			get
			{
				return _hRA_FIN;
			}
			set
			{
				SqlDateTime hRA_FINTmp = (SqlDateTime)value;
				if(hRA_FINTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("HRA_FIN", "HRA_FIN can't be NULL");
				}
				_hRA_FIN = value;
			}
		}


		public SqlString NOM_ENCARGADO
		{
			get
			{
				return _nOM_ENCARGADO;
			}
			set
			{
				SqlString nOM_ENCARGADOTmp = (SqlString)value;
				if(nOM_ENCARGADOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NOM_ENCARGADO", "NOM_ENCARGADO can't be NULL");
				}
				_nOM_ENCARGADO = value;
			}
		}


		public SqlString NOM_INSTITUCION
		{
			get
			{
				return _nOM_INSTITUCION;
			}
			set
			{
				SqlString nOM_INSTITUCIONTmp = (SqlString)value;
				if(nOM_INSTITUCIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("NOM_INSTITUCION", "NOM_INSTITUCION can't be NULL");
				}
				_nOM_INSTITUCION = value;
			}
		}


		public SqlString COD_IDENTIFICACION
		{
			get
			{
				return _cOD_IDENTIFICACION;
			}
			set
			{
				SqlString cOD_IDENTIFICACIONTmp = (SqlString)value;
				if(cOD_IDENTIFICACIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("COD_IDENTIFICACION", "COD_IDENTIFICACION can't be NULL");
				}
				_cOD_IDENTIFICACION = value;
			}
		}


		public SqlInt32 CAN_USUARIOS
		{
			get
			{
				return _cAN_USUARIOS;
			}
			set
			{
				SqlInt32 cAN_USUARIOSTmp = (SqlInt32)value;
				if(cAN_USUARIOSTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("CAN_USUARIOS", "CAN_USUARIOS can't be NULL");
				}
				_cAN_USUARIOS = value;
			}
		}


		public SqlInt32 FKY_TIPOSOLICITANTE
		{
			get
			{
				return _fKY_TIPOSOLICITANTE;
			}
			set
			{
				SqlInt32 fKY_TIPOSOLICITANTETmp = (SqlInt32)value;
				if(fKY_TIPOSOLICITANTETmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FKY_TIPOSOLICITANTE", "FKY_TIPOSOLICITANTE can't be NULL");
				}
				_fKY_TIPOSOLICITANTE = value;
			}
		}
		public SqlInt32 FKY_TIPOSOLICITANTEOld
		{
			get
			{
				return _fKY_TIPOSOLICITANTEOld;
			}
			set
			{
				SqlInt32 fKY_TIPOSOLICITANTEOldTmp = (SqlInt32)value;
				if(fKY_TIPOSOLICITANTEOldTmp.IsNull )
				{
					throw new ArgumentOutOfRangeException("FKY_TIPOSOLICITANTEOld", "FKY_TIPOSOLICITANTEOld can't be NULL");
				}
				_fKY_TIPOSOLICITANTEOld = value;
			}
		}


		public SqlString TXT_OBSERVACIONES
		{
			get
			{
				return _tXT_OBSERVACIONES;
			}
			set
			{
				_tXT_OBSERVACIONES = value;
			}
		}


		public SqlString DSC_RAZONUSO
		{
			get
			{
				return _dSC_RAZONUSO;
			}
			set
			{
				SqlString dSC_RAZONUSOTmp = (SqlString)value;
				if(dSC_RAZONUSOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("DSC_RAZONUSO", "DSC_RAZONUSO can't be NULL");
				}
				_dSC_RAZONUSO = value;
			}
		}


		public SqlString COD_TIPOSOLICITUD
		{
			get
			{
				return _cOD_TIPOSOLICITUD;
			}
			set
			{
				SqlString cOD_TIPOSOLICITUDTmp = (SqlString)value;
				if(cOD_TIPOSOLICITUDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("COD_TIPOSOLICITUD", "COD_TIPOSOLICITUD can't be NULL");
				}
				_cOD_TIPOSOLICITUD = value;
			}
		}


		public SqlString TXT_CORREO
		{
			get
			{
				return _tXT_CORREO;
			}
			set
			{
				SqlString tXT_CORREOTmp = (SqlString)value;
				if(tXT_CORREOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TXT_CORREO", "TXT_CORREO can't be NULL");
				}
				_tXT_CORREO = value;
			}
		}


		public SqlBoolean COD_ATENDIDO
		{
			get
			{
				return _cOD_ATENDIDO;
			}
			set
			{
				SqlBoolean cOD_ATENDIDOTmp = (SqlBoolean)value;
				if(cOD_ATENDIDOTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("COD_ATENDIDO", "COD_ATENDIDO can't be NULL");
				}
				_cOD_ATENDIDO = value;
			}
		}
		#endregion
	}
}
