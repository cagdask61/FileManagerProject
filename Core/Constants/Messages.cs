using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Constants
{
    public static class Messages
    {
        public static string FileLengthOutOfRange { get => "Yüklemek istediğiniz dosyanın boyutu sınırı aştı lütfen pro sürüme geçiniz!"; }
        public static string SuccessFileUpload { get => "Dosyanız başarıyla yüklendi."; }

        public static string SuccessFileDelete { get => "Dosyanız başarıyla Silindi."; }
        public static string SuccessFileUpdate { get => "Dosyanız başarıyla Güncellendi."; }
    }
}
