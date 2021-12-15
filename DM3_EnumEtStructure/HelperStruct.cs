 // La function CharTableRemoveAccents va remplacer tout les charWithAccents par ceux de charSource
namespace DM3_EnumEtStructure
{     
    public class Helper
    {
                static char[] charWithAccents = {'À','Á','Â','Ã','Ä','Å','Æ','Ç','È','É','Ê','Ë','Ì','Í','Î','Ï','Ð','Ñ','Ò','Ó','Ô','Õ','Ö','×','Ù','Ú','Û','Ü','Ý','Þ','ß','à','á','â','ã','ä','å','æ','ç','è','é','ê','ë','ì','í','î','ï','ð','ñ','ò','ó','ô','õ','ö','ù','ú','û','ü','ý','ÿ'};
        static char[] charSource = {'A','A','A','A','A','A','A','C','E','E','E','E','I','I','I','I','D','N','O','O','O','O','O','X','U','U','U','U','Y','P','B','A','A','A','A','A','A','A','C','E','E','E','E','I','I','I','I','O','N','O','O','O','O','O','U','U','U','U','Y','Y'};

        public static char[] CharTableRemoveAccents(char[] text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                for(int j = 0; j < charWithAccents.Length; j++)
                {
                    if(text[i] == charWithAccents[j])
                        text[i] = charSource[j];
                }
            } 
            return text;
        }
    }
}