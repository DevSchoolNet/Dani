namespace OOPLibrary {
    public interface IFrontOffice {
        void AddCustomer(string name, string CNP);
        bool OpenRelation(string name, string CNP);
        int Wage { get; set; }
        string EmployeeId { get; set; }
        string Department { get; set; }
    }
}