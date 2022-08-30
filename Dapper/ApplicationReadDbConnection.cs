﻿using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

public class ApplicationReadDbConnection : IApplicationReadDbConnection, IDisposable
{
    private readonly IDbConnection connection;
    public ApplicationReadDbConnection()
    {
        connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = DoctorWhoDB");
    }
    public async Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
    {
        return (await connection.QueryAsync<T>(sql, param, transaction)).AsList();
    }
    public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
    {
        return await connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction);
    }
    public async Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
    {
        return await connection.QuerySingleAsync<T>(sql, param, transaction);
    }
    public void Dispose()
    {
        connection.Dispose();
    }
}