using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed= "Ürünler Listelendi";
        public static string ProductCountOfCategoryError="Bir kategoriden en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var.";
        public static string CategoryLimitExceded="Kategori limit aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied ="Yetkiniz yok.";
        public static string UserRegistered ="Kullanıcı kayıtlı";
        public static string UserNotFound ="Kullanıcı bulunamadı";
        internal static string PasswordError="Şifre hatalı";
        internal static string SuccessfulLogin="Giriş başarılı.";
        internal static string UserAlreadyExists="Kullanıcı mevcut.";
        internal static string AccessTokenCreated="Access Token oluşturuldu.";
    }
}
