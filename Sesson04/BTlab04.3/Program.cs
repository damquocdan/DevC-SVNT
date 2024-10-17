using BTlab04._3;

internal class Program
{
    static void Main(string[] args)
    {
        Document document = new Document();
        //gán nội dung cho document
        document.content = "Đây là nộ dung của dọcument";
        //ghi vào file
        string filePath = "document.txt";
        document.Write(filePath);
        // dọc lại từ file
        document.Read(filePath);
        Console.WriteLine($"nội dung tài liệu:{document.content}");
        //mã hoá nội dung
        string encrytedContent = document.Encrypt();
        Console.WriteLine($"mã hoá nội dung:{encrytedContent}");

        // gán dữ liệu đã mã hoá cho document để thử giải mẫ
        document.content = encrytedContent;
        string decryptedContent = document.Decrypt();
        Console.WriteLine($"Decryted nội dung:{decryptedContent}");
    }
}