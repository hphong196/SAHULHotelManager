using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CDepartment
    {
        #region "Attribus"
        private int _id;                               // mã bộ phận
        private string _name;                          // tên bộ phận
        private CDepartment _parent;                   // thông tin bộ phận cha
        private CEmployee _chief;                      // thông tin trưởng bộ phận
        #endregion

        #region "Property"
        public new string ToString
        {
            get
            {
                return this.ShowInFors();
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public CEmployee Chief
        {
            get
            {
                return _chief;
            }

            set
            {
                _chief = value;
            }
        }

        public CDepartment Parent
        {
            get
            {
                return _parent;
            }

            set
            {
                _parent = value;
            }
        }
        public int ParentID
        {
            get
            {
                return Parent.Id;
            }
            set
            {
                Parent.Id = value;
            }
        }
        #endregion

        #region "Constructor"
        public CDepartment()
        {
            this.Id = 0;
            this.Name = String.Empty;
            this.ParentID = 0;
            this.Chief = new CEmployee();
        }
        public CDepartment(CDepartment CDepartment)
        {
            this.Id = CDepartment.Id;
            this.Name = CDepartment.Name;
            this.ParentID = CDepartment.ParentID;
            this.Chief = CDepartment.Chief;
        }
        public CDepartment(int id, string name, int ParentID)
        {
            this.Id = id;
            this.Name = name;
            this.ParentID = 0;
            this.Chief = null;
        }
        public CDepartment(int id, string name, int parentID, CEmployee chief)
        {
            this.Id = id;
            this.Name = name;
            this.ParentID = parentID;
            this.Chief = chief;
        }
        #endregion

        #region "Methods"
        public string ShowInFors()
        {
            return "ID: " + Id + '\n'
                   + "Name: " + Name + '\n'
                   + "Department Parent ID: " + ParentID + '\n'
                   + "Chief: " + Chief.ToString;
        }

        public List<CDepartment> GenerateObjects()
        {
            List<CDepartment> Departments = new List<CDepartment>();
            Departments.Add(new CDepartment(1, "bộ phận giám đốc", 0));
            Departments.Add(new CDepartment(2, "bộ phận kỹ thuật", 1));
            Departments.Add(new CDepartment(3, "bộ phận đặt phòng", 1));
            Departments.Add(new CDepartment(4, "bộ phận dọn phòng", 1));
            Departments.Add(new CDepartment(5, "bộ phận tiền sảnh", 1));
            Departments.Add(new CDepartment(6, "bộ phận nhà hàng và quầy uống", 1));
            Departments.Add(new CDepartment(7, "bộ phận nhân sự", 1));
            Departments.Add(new CDepartment(8, "bộ phận kế toán", 1));
            Departments.Add(new CDepartment(9, "bộ phận hướng dẫn khách hàng", 1));
            Departments.Add(new CDepartment(10, "bộ phận quan hệ khách hàng", 1));
            return Departments;
        }
        #endregion
    }
}