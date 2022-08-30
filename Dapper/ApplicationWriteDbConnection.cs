﻿using Dapper;
using DoctorWho.Db;
using System.Data;

public class ApplicationWriteDbConnection : IApplicationWriteDbConnection
{
    private readonly DoctorWhoCoreDbContext context;
    public ApplicationWriteDbConnection(DoctorWhoCoreDbContext context)
    {
        this.context = context;
    }
    public async Task<int> ExecuteAsync(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
    {
        return await context.Connection.ExecuteAsync(sql, param, transaction);
    }
    public async Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
    {
        return (await context.Connection.QueryAsync<T>(sql, param, transaction)).AsList();
    }
    public async Task<T> QueryFirstOrDefaultAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
    {
        return await context.Connection.QueryFirstOrDefaultAsync<T>(sql, param, transaction);
    }
    public async Task<T> QuerySingleAsync<T>(string sql, object param = null, IDbTransaction transaction = null, CancellationToken cancellationToken = default)
    {
        return await context.Connection.QuerySingleAsync<T>(sql, param, transaction);
    }
}