namespace HR_Application_DB_Logic.Models
{
    public class EmployeeDTO
    {
        public int ID { get; set; }
        public string Photo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegistrationDate { get; set; }
        public int StatusID { get; set; }
        public int LocationID { get; set; }
        public bool IsActual { get; set; }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is EmployeeDTO)
            {
                EmployeeDTO employeeDTO = (EmployeeDTO)obj;

                if (employeeDTO.ID == ID
                    && employeeDTO.Photo == Photo
                    && employeeDTO.FirstName == FirstName
                    && employeeDTO.LastName == LastName
                    && employeeDTO.RegistrationDate == RegistrationDate
                    && employeeDTO.StatusID == StatusID
                    && employeeDTO.LocationID == LocationID
                    && employeeDTO.IsActual == IsActual)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
