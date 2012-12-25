#region Acerca de...
///////////////////////////////////////////////////////////////////////////
// Empresa:  Instituto Tecnológico de Costa Rica
// Proyecto: UDsystem
// Descripción: Clase de acceso a datos para tabla 'UDGDFRESPUESTA'
// Generado por ITCR Gen v2010.0.0.0 
// Fecha: sábado, 22 de diciembre de 2012, 09:53:59 a.m.
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
	/// Propósito: Clase de acceso a datos para tabla 'UDGDFRESPUESTA'.
	/// </summary>
	public class cUDGDFRESPUESTABase : cBDInteraccionBase
	{
		#region Declaraciones de miembros de la clase
			private SqlInt32		_fKY_NOTIFICACION, _fKY_NOTIFICACIONOld, _fKY_SOLICITUD, _fKY_SOLICITUDOld, _iD_RESPUESTA;
			private SqlString		_tXT_OBSERVACION;
		#endregion


		/// <summary>
		/// Propósito: Constructor de la clase.
		/// </summary>
		public cUDGDFRESPUESTABase()
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
		///		 <LI>TXT_OBSERVACION</LI>
		///		 <LI>FKY_NOTIFICACION</LI>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>ID_RESPUESTA</LI>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Insertar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_Insertar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_OBSERVACION", SqlDbType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_OBSERVACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_NOTIFICACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_NOTIFICACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESPUESTA", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, _iD_RESPUESTA));
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
				_iD_RESPUESTA = Int32.Parse(cmdAEjecutar.Parameters["@iID_RESPUESTA"].Value.ToString());
				_codError = Int32.Parse(cmdAEjecutar.Parameters["@iCodError"].Value.ToString());

				if(_codError != (int)ITCRError.AllOk)
				{
					// Genera un error.
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESPUESTA_Insertar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::Insertar::Ocurrió un error." + ex.Message, ex);
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
		///		 <LI>ID_RESPUESTA</LI>
		///		 <LI>TXT_OBSERVACION</LI>
		///		 <LI>FKY_NOTIFICACION</LI>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Actualizar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_Actualizar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESPUESTA", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_RESPUESTA));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_OBSERVACION", SqlDbType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_OBSERVACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_NOTIFICACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_NOTIFICACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESPUESTA_Actualizar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::Actualizar::Ocurrió un error." + ex.Message, ex);
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
		/// Propósito: Método Update para actualizar una o más filas utilizando la llave foránea 'FKY_NOTIFICACION.
		/// Este método actualiza una o más filas existentes en la base de datos, actualiza el campo 'FKY_NOTIFICACION' en
		/// todas las filas que tienen ese valor para este campo con el valor 'FKY_NOTIFICACIONanterior 
		/// con el valor colocado en la propiedad 'FKY_NOTIFICACION'.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_NOTIFICACION</LI>
		///		 <LI>FKY_NOTIFICACIONOld</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public bool ActualizarTodos_Con_FKY_NOTIFICACION_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_ActualizarTodos_Con_FKY_NOTIFICACION_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_NOTIFICACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_NOTIFICACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_NOTIFICACIONOld", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_NOTIFICACIONOld));
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
					throw new Exception("Procedimiento almacenado 'pr_UDGDFRESPUESTA_ActualizarTodos_Con_FKY_NOTIFICACION_FK' reportó el error Código: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::ActualizarTodos_Con_FKY_NOTIFICACION_FK::Ocurrió un error." + ex.Message, ex);
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
		/// Propósito: Método Update para actualizar una o más filas utilizando la llave foránea 'FKY_SOLICITUD.
		/// Este método actualiza una o más filas existentes en la base de datos, actualiza el campo 'FKY_SOLICITUD' en
		/// todas las filas que tienen ese valor para este campo con el valor 'FKY_SOLICITUDanterior 
		/// con el valor colocado en la propiedad 'FKY_SOLICITUD'.
		/// </summary>
		/// <returns>True si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_SOLICITUD</LI>
		///		 <LI>FKY_SOLICITUDOld</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public bool ActualizarTodos_Con_FKY_SOLICITUD_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_ActualizarTodos_Con_FKY_SOLICITUD_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUDOld", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUDOld));
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
					throw new Exception("Procedimiento almacenado 'pr_UDGDFRESPUESTA_ActualizarTodos_Con_FKY_SOLICITUD_FK' reportó el error Código: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::ActualizarTodos_Con_FKY_SOLICITUD_FK::Ocurrió un error." + ex.Message, ex);
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
		///		 <LI>ID_RESPUESTA</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override bool Eliminar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_Eliminar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESPUESTA", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_RESPUESTA));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESPUESTA_Eliminar' reportó el error Codigo: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::Eliminar::Ocurrió un error." + ex.Message, ex);
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
		/// Propósito: Método Eliminar para una llave primaria. Este método va a borrar una o más filas en la base de datos, basado en la llave primaria 'FKY_NOTIFICACION'
		/// </summary>
		/// <returns>True si tuvo éxito, false otherwise. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_NOTIFICACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public bool EliminarTodo_Con_FKY_NOTIFICACION_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_EliminarTodo_Con_FKY_NOTIFICACION_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_NOTIFICACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_NOTIFICACION));
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
					throw new Exception("Procedimiento almacenado 'pr_UDGDFRESPUESTA_EliminarTodo_Con_FKY_NOTIFICACION_FK' reportó el error Código: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::EliminarTodo_Con_FKY_NOTIFICACION_FK::Ocurrió un error." + ex.Message, ex);
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
		/// Propósito: Método Eliminar para una llave primaria. Este método va a borrar una o más filas en la base de datos, basado en la llave primaria 'FKY_SOLICITUD'
		/// </summary>
		/// <returns>True si tuvo éxito, false otherwise. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public bool EliminarTodo_Con_FKY_SOLICITUD_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_EliminarTodo_Con_FKY_SOLICITUD_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
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
					throw new Exception("Procedimiento almacenado 'pr_UDGDFRESPUESTA_EliminarTodo_Con_FKY_SOLICITUD_FK' reportó el error Código: " + _codError);
				}

				return true;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::EliminarTodo_Con_FKY_SOLICITUD_FK::Ocurrió un error." + ex.Message, ex);
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
		///		 <LI>ID_RESPUESTA</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		///		 <LI>ID_RESPUESTA</LI>
		///		 <LI>TXT_OBSERVACION</LI>
		///		 <LI>FKY_NOTIFICACION</LI>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Llena todas las propiedades que corresponden al campo en tabla con el valor de la fila seleccionada.
		/// </remarks>
		public override DataTable SeleccionarUno()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_SeleccionarUno]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFRESPUESTA");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESPUESTA", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_RESPUESTA));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESPUESTA_SeleccionarUno' reportó el error Código: " + _codError);
				}

				if(toReturn.Rows.Count > 0)
				{
					_iD_RESPUESTA = (Int32)toReturn.Rows[0]["ID_RESPUESTA"];
					_tXT_OBSERVACION = (string)toReturn.Rows[0]["TXT_OBSERVACION"];
					_fKY_NOTIFICACION = (Int32)toReturn.Rows[0]["FKY_NOTIFICACION"];
					_fKY_SOLICITUD = (Int32)toReturn.Rows[0]["FKY_SOLICITUD"];
				}
				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::SeleccionarUno::Ocurrió un error." + ex.Message, ex);
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
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_SeleccionarTodos]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFRESPUESTA");
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESPUESTA_SeleccionarTodos' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::SeleccionarTodos::Ocurrió un error." + ex.Message, ex);
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
		/// Propósito: Método SELECT para una llave primaria. Este método hace Select de una o más filas de la base de datos, basado en la llave primaria 'FKY_NOTIFICACION'
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_NOTIFICACION</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public DataTable SeleccionarTodos_Con_FKY_NOTIFICACION_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_SeleccionarTodos_Con_FKY_NOTIFICACION_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFRESPUESTA");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_NOTIFICACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_NOTIFICACION));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESPUESTA_SeleccionarTodos_Con_FKY_NOTIFICACION_FK' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch(Exception ex)
			{
				// Ocurrió un error. Le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::SeleccionarTodos_Con_FKY_NOTIFICACION_FK::Ocurrió un error." + ex.Message, ex);
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
		/// Propósito: Método SELECT para una llave primaria. Este método hace Select de una o más filas de la base de datos, basado en la llave primaria 'FKY_SOLICITUD'
		/// </summary>
		/// <returns>DataTable object si tuvo éxito, sino genera una Exception. </returns>
		/// <remarks>
		/// Propiedades necesarias para este método: 
		/// <UL>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public DataTable SeleccionarTodos_Con_FKY_SOLICITUD_FK()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_SeleccionarTodos_Con_FKY_SOLICITUD_FK]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFRESPUESTA");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESPUESTA_SeleccionarTodos_Con_FKY_SOLICITUD_FK' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch(Exception ex)
			{
				// Ocurrió un error. Le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::SeleccionarTodos_Con_FKY_SOLICITUD_FK::Ocurrió un error." + ex.Message, ex);
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
		///		 <LI>ID_RESPUESTA</LI>
		///		 <LI>TXT_OBSERVACION</LI>
		///		 <LI>FKY_NOTIFICACION</LI>
		///		 <LI>FKY_SOLICITUD</LI>
		/// </UL>
		/// Propiedades actualizadas luego de una llamada exitosa a este método: 
		/// <UL>
		///		 <LI>CodError</LI>
		/// </UL>
		/// </remarks>
		public override DataTable Buscar()
		{
			SqlCommand	cmdAEjecutar = new SqlCommand();
			cmdAEjecutar.CommandText = "dbo.[pr_UDGDFRESPUESTA_Buscar]";
			cmdAEjecutar.CommandType = CommandType.StoredProcedure;
			DataTable toReturn = new DataTable("UDGDFRESPUESTA");
			SqlDataAdapter adapter = new SqlDataAdapter(cmdAEjecutar);

			// Usar el objeto conexión de la clase base
			cmdAEjecutar.Connection = _conexionBD;

			try
			{
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iID_RESPUESTA", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _iD_RESPUESTA));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@sTXT_OBSERVACION", SqlDbType.VarChar, 300, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, _tXT_OBSERVACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_NOTIFICACION", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_NOTIFICACION));
				cmdAEjecutar.Parameters.Add(new SqlParameter("@iFKY_SOLICITUD", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, _fKY_SOLICITUD));
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
					throw new Exception("Procedimiento Almacenado 'pr_UDGDFRESPUESTA_Buscar' reportó el error Código: " + _codError);
				}

				return toReturn;
			}
			catch (Exception ex)
			{
				// Ocurrió un error. le hace Bubble a quien llama y encapsula el objeto Exception
				throw new Exception("cUDGDFRESPUESTABase::Buscar::Ocurrió un error." + ex.Message, ex);
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
		public SqlInt32 ID_RESPUESTA
		{
			get
			{
				return _iD_RESPUESTA;
			}
			set
			{
				SqlInt32 iD_RESPUESTATmp = (SqlInt32)value;
				if(iD_RESPUESTATmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ID_RESPUESTA", "ID_RESPUESTA can't be NULL");
				}
				_iD_RESPUESTA = value;
			}
		}


		public SqlString TXT_OBSERVACION
		{
			get
			{
				return _tXT_OBSERVACION;
			}
			set
			{
				SqlString tXT_OBSERVACIONTmp = (SqlString)value;
				if(tXT_OBSERVACIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("TXT_OBSERVACION", "TXT_OBSERVACION can't be NULL");
				}
				_tXT_OBSERVACION = value;
			}
		}


		public SqlInt32 FKY_NOTIFICACION
		{
			get
			{
				return _fKY_NOTIFICACION;
			}
			set
			{
				SqlInt32 fKY_NOTIFICACIONTmp = (SqlInt32)value;
				if(fKY_NOTIFICACIONTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FKY_NOTIFICACION", "FKY_NOTIFICACION can't be NULL");
				}
				_fKY_NOTIFICACION = value;
			}
		}
		public SqlInt32 FKY_NOTIFICACIONOld
		{
			get
			{
				return _fKY_NOTIFICACIONOld;
			}
			set
			{
				SqlInt32 fKY_NOTIFICACIONOldTmp = (SqlInt32)value;
				if(fKY_NOTIFICACIONOldTmp.IsNull )
				{
					throw new ArgumentOutOfRangeException("FKY_NOTIFICACIONOld", "FKY_NOTIFICACIONOld can't be NULL");
				}
				_fKY_NOTIFICACIONOld = value;
			}
		}


		public SqlInt32 FKY_SOLICITUD
		{
			get
			{
				return _fKY_SOLICITUD;
			}
			set
			{
				SqlInt32 fKY_SOLICITUDTmp = (SqlInt32)value;
				if(fKY_SOLICITUDTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("FKY_SOLICITUD", "FKY_SOLICITUD can't be NULL");
				}
				_fKY_SOLICITUD = value;
			}
		}
		public SqlInt32 FKY_SOLICITUDOld
		{
			get
			{
				return _fKY_SOLICITUDOld;
			}
			set
			{
				SqlInt32 fKY_SOLICITUDOldTmp = (SqlInt32)value;
				if(fKY_SOLICITUDOldTmp.IsNull )
				{
					throw new ArgumentOutOfRangeException("FKY_SOLICITUDOld", "FKY_SOLICITUDOld can't be NULL");
				}
				_fKY_SOLICITUDOld = value;
			}
		}
		#endregion
	}
}
