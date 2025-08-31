namespace TrackDoc.Core.Entities
{
    public class User : BaseEntity
    {
        #region Fields

        private string mUserName;
        private string mPassword;
        private string mEmail;

        private ICollection<RepositoryMember> mMemberships;
        private ICollection<Repository> mOwnedRepositories;

        #endregion

        #region Properties

        public string UserName
        {
            get => mUserName;
            set => mUserName = value;
        }

        public string Password
        {
            get => mPassword;
            set => mPassword = value;
        }

        public string Email
        {
            get => mEmail;
            set => mEmail = value;
        }

        public ICollection<RepositoryMember> Memberships
        {
            get
            {
                if(mMemberships is null)
                    mMemberships = new List<RepositoryMember>();

                return mMemberships;
            }
            set => mMemberships = value;
        }

        public ICollection<Repository> OwnedRepositories
        {
            get
            {
                if(mOwnedRepositories is null)
                    mOwnedRepositories = new List<Repository>();

                return mOwnedRepositories;
            }
            set => mOwnedRepositories = value;
        }
        #endregion

        #region Constructors

        internal User() 
        : base()
        {
            mUserName = string.Empty;
            mPassword = string.Empty;
            mEmail = string.Empty;
            mMemberships = new List<RepositoryMember>();
            mOwnedRepositories = new List<Repository>();
        }

        public User
        (
            string username, 
            string password, 
            string email
        ) 
        : this()
        {
            mUserName = username;
            mPassword = password;
            mEmail = email;
        }

        #endregion
    }
}
