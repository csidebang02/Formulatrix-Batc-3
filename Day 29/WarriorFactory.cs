public class WarriorFactory : CharacterFactory
{
    public override Character CreateCharacter()
    {
        return new Warrior();
    }
}
