namespace TrackDoc.Core.Entities
{
    public abstract class BaseEntity
    {
        #region Fields

        private Guid mId;
        private DateTime mDateCreated;
        private DateTime? mDateUpdated;

        #endregion

        #region Properties

        public Guid Id
        {
            get => mId;
        }

        public DateTime DateCreated
        {
            get => mDateCreated;
        }

        public DateTime? DateUpdated
        {
            get
            {
                if (mDateUpdated is null)
                    mDateUpdated = mDateCreated;

                return mDateUpdated;
            }
            set => mDateUpdated = value;
        }

        #endregion

        #region Constructors

        protected BaseEntity()
        {
            mId = Guid.NewGuid();
            mDateCreated = DateTime.Now;
            mDateUpdated = mDateCreated;
        }

        #endregion
    }
}
