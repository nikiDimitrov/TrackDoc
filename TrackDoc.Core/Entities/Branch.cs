using System.IO.Enumeration;

namespace TrackDoc.Core.Entities
{
    public class Branch : BaseEntity
    {
        #region Fields

        private Guid mRepositoryId;
        private Repository mRepository;

        private string mName;
        private string mHeadCommitSha;

        private ICollection<Commit> mCommits;

        #endregion

        #region Properties

        public Guid RepositoryId
        {
            get => mRepositoryId;
        }

        public Repository Repository
        {
            get => mRepository;
            set
            {
                mRepository = value;

                if(mRepository is null ||
                   mRepository.Id != Guid.Empty)
                {
                    mRepositoryId = Guid.Empty;
                    return;
                }

                mRepositoryId = mRepository.Id;
            }
        }

        public string Name
        {
            get => mName;
            set => mName = value;
        }

        public string HeadCommitSha
        {
            get => mHeadCommitSha;
            set => mHeadCommitSha = value;
        }

        public ICollection<Commit> Commits
        {
            get
            {
                if(mCommits is null)
                    mCommits = new List<Commit>();

                return mCommits;
            }
            set => mCommits = value;
        }

        #endregion

        #region Constructors

        internal Branch()
        : base()
        {
            mRepositoryId = Guid.Empty;
            mRepository = null!;

            mName = string.Empty;
            mHeadCommitSha = string.Empty;

            mCommits = new List<Commit>();
        }

        public Branch
        (
            string name,
            Repository repository
        )
        : this()
        {
            mName = name;
            mRepository = repository;
        }

        #endregion
    }
}
