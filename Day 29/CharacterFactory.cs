public abstract class CharacterFactory
{
    public abstract Character CreateCharacter();
}
// Perhatikan bahwa metode createCharacter() bersifat abstrak, yang berarti setiap subkelas dari CharacterFactory harus menyediakan implementasi metode ini sendiri.
// Membuat kelas WizardFactory dan ArcherFactory yang memperluas CharacterFactory dan mengimplementasikan metode createCharacter() untuk mengembalikan Wizard atau Archer.	
