namespace NhaSachDotNet.DTO
{
    public class PaginationObject<T>
    {
        public List<T> content {  get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public int total { get; set; }

        public PaginationObject(List<T> content, int page, int pageSize){
            this.content = content;
            this.page = page;
            this.pageSize = pageSize;
            total = (int)Math.Ceiling(content.Count / (double)pageSize);
        }

        public PaginationObject() 
        {
            content = new List<T>();
        }

        public static PaginationObject<T> Create(List<T> source, int pageIndex, int pageSize)
        {
            var total = source.Count();
            var content = source.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList();
            return new PaginationObject<T>(content, pageIndex, pageSize);
        }
    }
}
