namespace ElevenNote.Services.Wrappers
{

    public class PaginationFilter
    {
        private const int _maxPageSize = 6;
        private int pageSize;


        public int PageNumber { get; set; } = 1;
        public int PageSize
        {
            get => pageSize;
            set => pageSize = value > _maxPageSize ? _maxPageSize : value;
        }


    }

}