namespace BankingSystem.Common;

public static class ApiRoutes
{
    private const string Root = "api";
    private const string Version = "v1";
    private const string Base = Root + "/" + Version;
    
    public static class Identity
    {
        public const string GetAll = $"{Base}/Identity";
        public const string Register = $"{Base}/Register";
        public const string Login = $"{Base}/Login";
    }
    public static class BankAccount
    {
        public const string GetByUser = $"{Base}/BankAccount";
        public const string GetById = $"{Base}/BankAccount" + "/{id}";
        public const string Withdraw = $"{Base}/BankAccount/Withdraw";
        public const string Replenish = $"{Base}/BankAccount/Replenish";
        public const string TopUp = $"{Base}/BankAccount/Topup";
    }

    public static class HealthCheck
    {
        public const string Check = $"{Base}/{nameof(HealthCheck)}";
    }
}