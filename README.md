Uygulama basit bir proxy console application'dır. </br>
Bu uygulama ile dış login servisleri kullanarak authenticate yapmaktayız. </br>
authenticate işleminden sonra alınan token ile diğer apilere istek atılabilecektir. </br>
in-memory bir şekilde token ve diğer bilgileri tutmaktadır. Herhangi bir data store edilmemektedir. </br>
3 Adet class bulunmaktadır. </br>
AuthService: </br>
  login metoduyla external bir api ile login authentication işlemi yapar sonucunda bir token alır ve tokenManager içerisine gönderir. </br>
SomeApiService: </br>
  Token'ı header'a koyarak tüketeceğimiz dış bir servis </br>
TokenManager: AddToken, GetToken ve RemoveToken adında 3 adet servis bulunmaktadır. Token işlemleri bu sınıfta yapılmaktadır. </br>
