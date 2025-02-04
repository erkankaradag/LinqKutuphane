# LINQ Kütüphane Uygulaması

Bu proje, LINQ kullanarak yazarlar ile kitaplar arasında bir **Join** işlemi yapmayı gösteren basit bir **C# konsol uygulamasıdır**. 

## İçerik
- **Yazarlar Listesi**: `Author` nesneleri
- **Kitaplar Listesi**: `Book` nesneleri
- **LINQ Join**: Yazarlar ile kitapları **AuthorId** üzerinden eşleştirme
- **Sonuçları Konsola Yazdırma**

## Kullanılan Teknolojiler
- **C#** (C Sharp)
- **.NET Framework**
- **LINQ** (Language Integrated Query)

## Kod Yapısı
Ana kod bloğu aşağıdaki gibidir:

```csharp
// Yazar ve Kitap Sınıfları
public class Author
{
    public int AuthorId { get; set; }
    public string AuthorName { get; set; }
}

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public int AuthorId { get; set; }
}

// Yazarlar ve Kitaplar Listesi
List<Author> authors = new List<Author>()
{
   new Author {AuthorId = 1, AuthorName = "Orhan Pamuk"},
   new Author {AuthorId = 2, AuthorName= "Elif Şafak"},
   new Author {AuthorId = 3, AuthorName= "Ahmet Ümit"}
};

List<Book> books = new List<Book>()
{
    new Book {BookId = 1, Title = "Kar", AuthorId = 1},
    new Book {BookId = 2, Title = "İstanbul", AuthorId = 1},
    new Book {BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2},
    new Book {BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3}
};

// LINQ ile Join
var query = from author in authors
            join book in books
            on author.AuthorId equals book.AuthorId
            select new
            {
                AuthorName = author.AuthorName,
                BookTitle = book.Title
            };

foreach (var item in query)
{
    Console.WriteLine($"{item.AuthorName} - {item.BookTitle}");
}
```

## Beklenen Konsol Çıktısı
```
Orhan Pamuk - Kar
Orhan Pamuk - İstanbul
Elif Şafak - 10 Minutes 38 Seconds in This Strange World
Ahmet Ümit - Beyoğlu Rapsodisi
```

## Nasıl Kullanılır?
1. Projeyi Visual Studio veya herhangi bir C# IDE'sinde açın.
2. `Program.cs` dosyasını çalıştırın.
3. Konsolda **yazar-ad ve kitap-başlık** eşleşmesi görünecektir.

## Lisans
Bu proje **MIT Lisansı** altında sunulmuştur.
