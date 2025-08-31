namespace TrackDoc.Core.Entities
{
    public class DocumentType : BaseEntity
    {
        #region Fields

        private string mName;
        private string mExtension;
        private DiffStrategy mDiffStrategy;

        private ICollection<Document> mDocuments;

        #endregion

        #region Properties

        public string Name
        {
            get => mName;
            set => mName = value;
        }

        public string Extension
        {
            get => mExtension;
            set => mExtension = value;
        }

        public DiffStrategy DiffStrategy
        {
            get => mDiffStrategy;
            set => mDiffStrategy = value;
        }

        public ICollection<Document> Documents
        {
            get
            {
                if(mDocuments is null)
                    mDocuments = new List<Document>();

                return mDocuments;
            }
            set => mDocuments = value;
        }

        #endregion

        #region Constructors

        internal DocumentType()
        : base()
        {
            mName = string.Empty;
            mExtension = string.Empty;
            mDiffStrategy = DiffStrategy.Default;
            mDocuments = new List<Document>();
        }

        public DocumentType
        (
            string name,
            string extension,
            DiffStrategy diffStrategy
        ) 
        : this()
        {
            mName = name;
            mExtension = extension;
            mDiffStrategy = diffStrategy;
        }

        #endregion
    }
}
