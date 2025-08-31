namespace TrackDoc.Core.Entities
{
    public class RepositoryMember : BaseEntity
    {
        #region Fields

        private Guid mUserId;
        private User mUser;

        private Guid mRepositoryId;
        private Repository mRepository;

        private RepositoryMemberRole mRole;

        #endregion

        #region Properties

        public Guid UserId
        {
            get => mUserId;
        }

        public User User
        {
            get => mUser;
            set
            {
                mUser = value;

                if (mUser is null ||
                    mUser.Id == Guid.Empty)
                {
                    mUserId = Guid.Empty;
                    return;
                }

                mUserId = mUser.Id;
            }
        }

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
                   mRepository.Id == Guid.Empty)
                {
                    mRepositoryId = Guid.Empty;
                    return;
                }

                 mRepositoryId = mRepository.Id;
            }
        }

        public RepositoryMemberRole Role
        {
            get => mRole;
            set => mRole = value;
        }

        #endregion

        #region Constructors

        internal RepositoryMember()
        : base()
        {
            mUserId = Guid.Empty;
            mUser = null!;
            mRepositoryId = Guid.Empty;
            mRepository = null!;
            mRole = RepositoryMemberRole.Viewer;
        }

        public RepositoryMember
        (
            User user, 
            Repository repository
        ) 
        : this()
        {
            mUser = user;
            mRepository = repository;
        }

        public RepositoryMember
        (
            User user,
            Repository repository,
            RepositoryMemberRole role
        ) 
        : this(user, repository)
        {
            mRole = role;
        }

        #endregion
    }
}
