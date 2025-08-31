namespace TrackDoc.Core.Entities
{
    public class Document : BaseEntity
    {
        #region Fields

        private Guid mRepositoryId;
        private Repository mRepository;

        private string mPath;
        private DocumentType mType;

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
                   mRepository.Id == Guid.Empty)
                {
                    mRepositoryId = Guid.Empty;
                    return;
                }

                mRepositoryId = mRepository.Id;
            }
        }

        public string Path
        {
            get => mPath;
            set => mPath = value;
        }

        public DocumentType Type
        {
            get => mType;
            set => mType = value;
        }

        #endregion

        #region Constructors

        internal Document()
        : base()
        {
            mRepositoryId = Guid.Empty;
            mRepository = null!;
            mPath = string.Empty;
            mType = null!;
        }

        public Document
        (
            Repository repository,
            string path,
            DocumentType type
        ) 
        : this()
        {
            mRepository = repository;
            mRepositoryId = repository.Id;
            mPath = path;
            mType = type;
        }

        #endregion
    }
}
