# C# Egitim Kampı 

M&Y Yazılım Eğitim Akademi Danışmanlık bünyesinde youtube tarafında C# için yapılan "Sertifikalı" bir eğitim projesidir.

# FrmStatistics
![frmStatistics](https://github.com/hasan-bozkus/CSharpEgitimKampi301/blob/master/CSharpEgitimKampi301.EFProject/frmStatistics.png)

# FrmStatistics Proje Detayları

➡️ <b> Tüm işlemlerde Entity Framework kullanarak Windofws Form uygulamasında 12 verinin çekildği bir isatistik tablosu hazırladık<br>

📍 <b> Lokasyon Sayısı: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Count() metoud ile Location tablosunda ne kadar lokasyon varsa çekip, ToString() metodu ile ekrana yazıdırdık.
<br />
📍 <b> Toplam Kapasite: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Sum() metoud ile Location tablosunda yer alan bütün tur rotalarının kapasite sayasını toplayıp, ToString() metodu ile ekrana yazıdırdık.
<br />
📍 <b> Rehber Sayısı: </b> Veri tabanı bağlantısı ile erişitiğimiz Guide tablosunda Count() metoud ile Guide tablosunda yer alan rehberlerin sayısını çekip, ToString() metodu ile ekrana yazıdırdık.
<br />
📍 <b> Ortalama Kapasite: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Average() metoud ile Location tablosunda yer alan Capaticty değerine ait bütün kapasite değerlerinin ortalamsını alıp, ToString() metodu ile ekrana yazıdırdık.
<br />
📍 <b> Ortalama Tur Fiyatı: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Average() metoud ile Location tablosunda yer alan Price değerine ait bütün fiyatların ortalamasını alıp, string.Format() metodu içine alarak ekrana yazıdırdık.
<br />
📍 <b> Son Eklenen Ülke: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Max() metoud ile Location tablosunda yer alan en yüksek Id değerini alıp, Where() metodu ile Location tablosundaki Id sütunu bulduğumuz en yüksek id değerine eşit olması durumunda, Select() metodu ile bulunan id değerinin sahip oludğu Ülke değerini FirstOrDefault() metodu ile ekrana yazdırdık.
<br />
📍 <b> Kapadokya Tur Kapasitesi: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Where() metoud ile Location tablosunda yer alan City değerinin Kapadokya olamsı halinde, Select() metodu ile Capacity değerini FirstOrDefault() metodu ile alıp ToStirng() metodu ile ekrana yazıdırdık.
<br />
📍 <b> Türkiye Turları Ortalama Kapasite: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Where() metoud ile Location tablosunda yer alan Country değrinin Türkiye olması durumunda, AverageR() metodu Capacity değerlerini ortalamasını alıp, ToString() metodu ile ekrana yazıdırdık.
<br />
📍 <b> Roma Gezi Rehberi: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Where() metoud ile Location tablosunda yer alan City değerinin Roma Turistik olması durumunda Select() metodu ile Location tablosundaki GuideId değerini FirstOrDefault() metoud ile alıp, veri tabanı bağlantısı ile eriştiğimiz Guide tablosunda Where() metodu ile Guide tablosunda yer alan GuideId değerini bulduğumuz GuideId ile eşitleyip, Select() metodu ile Guide tablosunda yer alan Rehber'in Ad ve Soyad (GuideName, GuideSurname) değerlerini FirstOrDefault() metodu ile alıp, ToString metodu ile ekrana yazdırdık.
<br />
📍 <b> En Yüksek Kapasiteli Tur: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Max() metoud ile Location tablosunda yer alan en yüksek Capacity değerini buluyoruz, Where() metodu ile Lacotion tablosundaki Capacity değerini bulduğmuz Capatiy değerine eşit olması durumunda, Location tablosunda en yüksek kapasiteli turun City değeri FirstOrDefault() metodu ile değerini alıp, ToString() metodu ile ekrana yazdırdık.
<br />
📍 <b> En Pahallı Tur: </b> Veri tabanı bağlantısı ile erişitiğimiz Location tablosunda Max() metoud ile Location tablosunda yer alan en yüksek Price değerini buluyoruz, Where() metodu ile Lacotion tablosundaki Price değerini bulduğmuz Price değerine eşit olması durumunda, Location tablosunda en yüksek Fiyatlı turun City değeri FirstOrDefault() metodu ile değerini alıp, ToString() metodu ile ekrana yazdırdık.
<br />
📍 <b> Ayşegül Çınar Tur Sayısı: </b> Veri tabanı bağlantısı ile erişitiğimiz Guied tablosunda Where() metoud ile Guide tablosunda yer alan GuideName'in Ayşegül, GuideSurname'in Çınar olması halinde Select() metodu ile GuideName ve GuideSurname'nin bağlı oludğu Id değerini seçip FirstOrDefault() metoudu ile alıyoruz, veri tabanı bağlantısı ile eriştiğimiz Location tablosunda Where() metodu ile Location tablosunda yer alan GuideId değerini bizim bulduğmuz GuideId değerine eşitleyip, Count() metodu ile ilgili GuideId'nin sahip olduğu tur sayısını alıp, ToString() metodu ile ekrana yazdırdık.
