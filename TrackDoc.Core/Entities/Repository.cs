namespace TrackDoc.Core.Entities
{
    public class Repository : BaseEntity
    {
        #region Fields

        private string mName;
        private string mDescription;
        private RepositoryVisiblity mVisibility;
        private string mUrl;
        private string mGitPath;

        private ICollection<RepositoryMember> mMembers;
        private ICollection<Branch> mBranches;

        #endregion

        #region Properties

        public string Name
        {
            get => mName;
            set => mName = value;
        }

        public string Description
        {
            get => mDescription;
            set => mDescription = value;
        }

        public RepositoryVisiblity Visibility
        {
            get => mVisibility;
            set => mVisibility = value;
        }

        public string Url
        {
            get => mUrl;
            set => mUrl = value;
        }

        public string GitPath
        {
            get => mGitPath;
            set => mGitPath = value;
        }

        public ICollection<RepositoryMember> Members
        {
            get
            {
                if(mMembers is null)
                    mMembers = new List<RepositoryMember>();

                return mMembers;
            }
            set => mMembers = value;
        }

        public ICollection<Branch> Branches
        {
            get
            {
                if (mBranches is null)
                    mBranches = new List<Branch>();

                return mBranches;
            }
            set => mBranches = value;
        }

        #endregion

        #region Constructors

        internal Repository() 
        : base()
        {
            mName = string.Empty;
            mDescription = string.Empty;
            mVisibility = RepositoryVisiblity.Public;
            mUrl = string.Empty;
            mGitPath = string.Empty;
            mMembers = new List<RepositoryMember>();
            mBranches = new List<Branch>();
        }
        
        public Repository
        (
            string name,
            string description,
            RepositoryVisiblity visibility,
            string url,
            string gitPath
        ) 
        : this()
        {
            mName = name;
            mDescription = description;
            mVisibility = visibility;
            mUrl = url;
            mGitPath = gitPath;
        }

        #endregion
    }
}
