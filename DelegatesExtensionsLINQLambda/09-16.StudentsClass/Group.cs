namespace _09_16.StudentsClass
{
    public class Group
    {
        public Group(uint numberOfGroup, string nameOfDepartment)
        {
            this.GroupNumber = numberOfGroup;
            this.DepartmentName = nameOfDepartment;
        }

        public uint GroupNumber { get; set; }
        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return this.DepartmentName;
        }
    }
}
