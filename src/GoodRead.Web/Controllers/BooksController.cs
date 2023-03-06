using GoodRead.Domain.Entities.Books;
using Microsoft.AspNetCore.Mvc;

namespace GoodRead.Web.Controllers;

[Route("books")]
public class BooksController : Controller
{
    public IActionResult Index()
    {
        var books = new List<Book>()
        {
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Jorj Oruell: Molxona",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },new Book()
            {
                Id = 1,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Charlz Uilan: Yalang‘och iqtisodiyot. Murakkab sohaning sodda qiyofasi",
                Description = "Dunyo kitobxonlariga sevimli boʻlib ulgurgan “Yalangʻoch iqtisodiyot. ﻿Murakkab sohaning sodda qiyofasi” kitobi endi oʻzbek tilida!",
                Price = 75000,
            },
            new Book()
            {
                Id = 3,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Jeyms Klir: Atom odatlar",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 45000,
            },
            new Book()
            {
                Id = 4,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Teodor Drayzer: Sarmoyador",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Hans Rosling: Factfulness",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Klaus Shvab: To'rtinchi sanoat inqilobi",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Rey Bredberi: Farengeyt bo'yicha 451º",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Den Braun: Ibtido (yumshoq muqova)",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Den Braun: Raqamli qalʼa",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Oldos Haksli: Ajib yangi dunyo",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Ramita Navai: Yolg‘onlar shahri",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Jon G. Miller: COC! Savol ortidagi savol",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Jorj Oruell: 1984 (Qattiq)",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Paulo Koelo: Alif",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
            new Book()
            {
                Id = 0,
                ImagePath = @"media\avatars\150-13.jpg",
                Title = "Deniyel Kiz: Eljernonga atalgan gullar",
                Description = "Jorj Oruell (ingl. George Orwell, haqiqiy ismi-sharifi Erik Artur Bler) — ingliz yozuvchisi bo‘lib, g‘ayrixayoliy “1984” romani  va “Molxona” rivoyat-qissasining muallifidir. Jorj Oruell “Molxona” asarini 1943 yil noyabridan to 1944  yil fevraligacha yozgan va 1945 yil avgustida eʼlon qilgan. Kitobni har bir inson o‘qishi va mulohaza qilishi lozim: nega bu dunyomiz shunday, u aslida qanday bo‘lishi kerak...",
                Price = 29000,
            },
        };
        return View(books);
    }
}
