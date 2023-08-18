using System;

public class Game
{
    public static void Main(string[] args)
    {
        CharacterFactory factory = new WarriorFactory();
        Character character = factory.CreateCharacter();
        character.Attack();
        character.Defend();
    }
}
// kita dapat menggunakan CharacterFactory dan subkelasnya untuk membuat karakter baru di kelas Game kita:
// kita memiliki tiga kelas yang mengimplementasikan antarmuka Karakter. Kita juga memiliki tiga kelas Factory: WarriorFactory, WizardFactory, dan ArcherFactory, yang masing-masing membuat jenis objek Karakter yang sesuai.
// Di kelas Game, kita membuat objek Factory (CharacterFactory) dan kemudian menggunakannya untuk membuat objek Karakter (karakter). Kita kemudian dapat menggunakan metode menyerang dan bertahan pada objek karakter tersebut tanpa perlu mengetahui kelas dari objek yang dibuat.
// Keuntungan menggunakan pola Factory Method adalah memungkinkan kita untuk membuat objek tanpa mengaitkan kode kita dengan kelas tertentu. Hal ini membuat kode kita lebih fleksibel dan lebih mudah untuk dipelihara, karena kita dapat dengan mudah menukar implementasi yang berbeda dari Karakter tanpa harus memodifikasi kode kita yang lain.

