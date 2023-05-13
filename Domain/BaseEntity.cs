namespace Domain
{
    public class BaseEntity : Object
    {

        #region Constructors
        public BaseEntity() : base()
        {

        }

        #endregion /Constructors

        #region Properties
        /// <summary>
        /// حذف شده
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// وضعیت
        /// </summary>
        public bool IsActive { get; set; }

        public string Username { get; set; }


        #endregion /Properties
    }
}
