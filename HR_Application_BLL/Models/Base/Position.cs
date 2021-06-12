using HR_Application_BLL.Models.Base;

namespace HR_Application_BLL.Base.Models
{
    public class Position
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string HiredDate { get; set; }
        public string FiredDate { get; set; }
        public bool IsActual { get; set; }
        public PositionModel Post { get; set; }
        public LevelsPositionModel Level { get; set; }

        public Position()
        {
            Level = new LevelsPositionModel();
            Post = new PositionModel();
        }
        public override string ToString()
        {
            return $"{Post} {Level}";
        }

        public override bool Equals(object obj)
        {
            bool result = false;

            if (obj is Position)
            {
                Position employeePosition = (Position)obj;
                if (employeePosition.ID == ID
                   && employeePosition.EmployeeID == EmployeeID
                   && employeePosition.HiredDate == HiredDate
                   && employeePosition.FiredDate == FiredDate
                   && employeePosition.IsActual == IsActual
                   && employeePosition.Level.Equals(Level)
                   && employeePosition.Post.Equals(Post))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}