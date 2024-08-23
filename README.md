<h1>MARKET UYGULAMASI</h1>
<h3> - Bu otomasyon uygulamasında , bir süper marketin kasa ve ödeme işlemlerini gerçekleştirebileceği bir sistem amaçlandı.</h3>
<h3> - Uygulamanın ön yüzünün tasarımı Windows Form ile yapıldı . Arka yüz işlemleri de C# ile kodlandı.</h3>
<h2>Uygulama Kullanımı için Gereksinimler</h2>

<h4> Uygulamanın veir tabanı işlemleri için aşağıdaki tabloları SQL SERVER MANGEMENT STUDIO'da oluşturmanız gerekiyor. (DB_MARKET adında bir veri tabanı oluşturup aşağıdaki kodu direkt çalıştırırsanız tablolar başarılı bir şekilde oluşturualcaktır.)</h4>

	USE [DB_MARKET]
	GO

	/****** Object:  Table [dbo].[TBLALISVERIS]    Script Date: 22.08.2024 16:40:11 ******/
	SET ANSI_NULLS ON
	GO

	SET QUOTED_IDENTIFIER ON
	GO

	CREATE TABLE [dbo].[TBLALISVERIS](
		[ALISVERISID] [int] IDENTITY(1,1) NOT NULL,
		[URUNAD] [varchar](100) NULL,
		[MARKAAD] [varchar](100) NULL,
		[URUNADET] [tinyint] NULL,
		[TOPLAMTUTAR] [decimal](18, 2) NULL,
		[ALISVERISTARIH] [date] NULL,
	 CONSTRAINT [PK_TBLALISVERIS] PRIMARY KEY CLUSTERED 
	(
		[ALISVERISID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	GO

	USE [DB_MARKET]
	GO

	/****** Object:  Table [dbo].[TBLKATEGORI]    Script Date: 22.08.2024 16:44:34 ******/
	SET ANSI_NULLS ON
	GO

	SET QUOTED_IDENTIFIER ON
	GO

	CREATE TABLE [dbo].[TBLKATEGORI](
		[KATEGORIID] [int] IDENTITY(1,1) NOT NULL,
		[KATEGORIAD] [varchar](100) NULL,
 	CONSTRAINT [PK_TBLKATEGORI] PRIMARY KEY CLUSTERED 
	(
		[KATEGORIID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	GO


	USE [DB_MARKET]
	GO

	/****** Object:  Table [dbo].[TBLKULLANICI]    Script Date: 22.08.2024 16:45:23 ******/
	SET ANSI_NULLS ON
	GO

	SET QUOTED_IDENTIFIER ON
	GO

	CREATE TABLE [dbo].[TBLKULLANICI](
		[ID] [int] IDENTITY(1,1) NOT NULL,
		[KULLANICIAD] [varchar](50) NULL,
		[MAIL] [varchar](100) NULL,
		[SIFRE] [varchar](10) NULL,
 	CONSTRAINT [PK_TBLKULLANICI] PRIMARY KEY CLUSTERED 
	(
		[ID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	GO


	USE [DB_MARKET]
	GO

	/****** Object:  Table [dbo].[TBLMARKA]    Script Date: 22.08.2024 16:46:14 ******/
	SET ANSI_NULLS ON
	GO

	SET QUOTED_IDENTIFIER ON
	GO

	CREATE TABLE [dbo].[TBLMARKA](
		[MARKAID] [int] IDENTITY(1,1) NOT NULL,
		[MARKAAD] [varchar](100) NULL,
		[KATEGORIID] [int] NULL,
 	CONSTRAINT [PK_TBLMARKA] PRIMARY KEY CLUSTERED 
	(
		[MARKAID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	GO

	ALTER TABLE [dbo].[TBLMARKA]  WITH CHECK ADD  CONSTRAINT [FK_TBLMARKA_TBLKATEGORI] FOREIGN KEY([KATEGORIID])
	REFERENCES [dbo].[TBLKATEGORI] ([KATEGORIID])
	GO

	ALTER TABLE [dbo].[TBLMARKA] CHECK CONSTRAINT [FK_TBLMARKA_TBLKATEGORI]
	GO


	USE [DB_MARKET]
	GO

	/****** Object:  Table [dbo].[TBLURUN]    Script Date: 22.08.2024 16:46:56 ******/
	SET ANSI_NULLS ON
	GO

	SET QUOTED_IDENTIFIER ON
	GO

	CREATE TABLE [dbo].[TBLURUN](
		[URUNID] [int] IDENTITY(1,1) NOT NULL,
		[URUNAD] [varchar](100) NULL,
		[MARKAAD] [varchar](100) NULL,
		[KATEGORIID] [int] NULL,
		[URUNBARKOD] [int] NULL,
		[URUNSTOK] [tinyint] NULL,
		[URUNFIYAT] [decimal](18, 2) NULL,
 	CONSTRAINT [PK_TBLURUNLER] PRIMARY KEY CLUSTERED 
	(
		[URUNID] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
	) ON [PRIMARY]
	GO

	ALTER TABLE [dbo].[TBLURUN]  WITH CHECK ADD  CONSTRAINT [FK_TBLURUN_TBLKATEGORI] FOREIGN KEY([KATEGORIID])
	REFERENCES [dbo].[TBLKATEGORI] ([KATEGORIID])
	GO

	ALTER TABLE [dbo].[TBLURUN] CHECK CONSTRAINT [FK_TBLURUN_TBLKATEGORI]
	GO


<h2> Uygulama Kullanım Kılavuzu </h2>
<h3> -> Uygulamayı başlatınca direkt giriş sayfasıyla karşılaşacaksınız.Eğer sisteme kayıtlıysanız direkt kullanıcı adı ve şifre ile giriş yapabilirsiniz. </h3>

![giris_foto](https://github.com/user-attachments/assets/eb6cd3e1-ea6a-4421-9c31-124486d9c865)

<h4>     -> Eğer sisteme kayıtlı değilseniz <b>"Kayıt Ol"</b> butonuna tıklayarak Kullanıcı <b>Kayıt Paneline</b> gidebilir ve sonrasında sisteme kayıt olabilirsiniz.</h4>
<h3> -> Uygulamaya giriş yaptıktan sonra Ana Sayfaya yönlendirileceksiniz.Burada <strong>"Ürünler"</strong> , <strong>"Markalar"</strong> ve <strong>"Alış Veriş"</strong> seçeneklerinden seçim yaparak istediğiniz sayfaya gidebilirsiniz.</h3>

![anasayfa_foto](https://github.com/user-attachments/assets/175fa793-c075-4af7-b523-fe2044cb3a75)

<h4>     -> Ürünler : Bu sayfada isterseniz <b>"Yeni Ürün Ekle"</b> butonuna tıklayarak ürün ekleme sayfasına gidebilirsiniz . Dilerseniz de ürünler listesinden herhangi bir ürüne tıklayıp güncelleme , silme işlemlerini yapabilirsiniz.Ayrı olarak ürün barkod numarasına göre ürün de arayabilirsiniz.</h4>

![urunler_foto](https://github.com/user-attachments/assets/a6b69e6d-4853-4ae4-84a8-b4275419f945)

<h5>        -> Yeni Ürün Ekleme : Eklemek istediğiniz ürünün barkod , stok , fiyat , marka , kategori , ürün ad bilgilerini girerek sisteme ekleyebilirsiniz.</h5>

![urun_ekle_foto](https://github.com/user-attachments/assets/79d694e8-7c9a-4d47-b5ec-abad7c562729)

<h4>     -> Markalar : Kategoriye göre yeni marka ekleme işlemini , olan markaları güncelleme , silme gibi işlemleri bu sayfada yapabilirsiniz.</h4>

![markalar_foto](https://github.com/user-attachments/assets/87559f5b-dab8-4c68-a915-002eb543758b)

<h4>     -> Alış Veriş : Müşterilerinin almış olduğu ürünlerin barkodlarını girerek ürün bilgilerini görüntüleyebilir , adede göre fiyat hesaplatabilir ve daha sonrasında "Sepete Ekle" butonuyla ürünleri sepete ekleyebilirsiniz. Ardından müşterinin verdiğin ücrete göre ödeme iptal edilebilir veyahut ödeme gerçekleştirilip alış veriş fişi görüntülenebilir. </h4>

![alisveris_foto_1](https://github.com/user-attachments/assets/301973cc-8561-4ac5-95f8-bb138754ff9f)

![alisveris_foto_2](https://github.com/user-attachments/assets/9c303c05-78d4-4c47-9ffe-2627e503ca7c)

![alisveris_foto_3_yeni](https://github.com/user-attachments/assets/640e0018-2e95-4d94-b643-c047b1a69c87) 

![alisveris_foto_4](https://github.com/user-attachments/assets/238bf377-276d-4450-a24e-6c01cd9f15cd)

