using DoctorWho.Db;

public class DoctorWhoController {
    public DoctorWhoCoreDbContext DbContext { get; }
    public IApplicationReadDbConnection readDbConnection {get;}
    public IApplicationWriteDbConnection _writeDbConnection { get; }

    public DoctorWhoController(DoctorWhoCoreDbContext dbContext,IApplicationReadDbConnection readDbConnection, IApplicationWriteDbConnection writeDbConnection)
    {
         this.DbContext = dbContext;
        this.readDbConnection = readDbConnection;
        _writeDbConnection = writeDbConnection;
    }
}