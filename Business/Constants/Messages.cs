using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba bilgileri eklendi.";
        public static string CarUpdated = "Araba bilgileri güncellendi.";
        public static string CarDeleted = "Araba bilgileri silindi.";
        public static string MaintenanceTime = "Sistem Bakımda!";
        public static string CarsListed = "Arabalar listelendi.";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string CustomerAdded ="Müşteri eklendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string RentalAdded = "Kiralama bilgileri kaydedildi.";
        public static string RentalDeleted = "Kiralama bilgileri silindi.";
        public static string RentalUpdated = "Kiralama bilgileri güncellendi.";
        public static string ImageLimitExceeded = "Bir arabanın en fazla 5 resmi olabilir.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut.";
        public static string AccessTokenCreated = "Token oluşturuldu.";
        public static string UserRegistered = "Kayıt oldu.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
