namespace Modul2HW4
{
    public class SafariPark
    {
        private ChordatesAnimal[] _section = new ChordatesAnimal[10];
        private int _count = 0;
        public SafariPark()
        {
            _section[0] = (ChordatesAnimal)new Mouse();
            _section[1] = (ChordatesAnimal)new Bunny();
            _section[2] = (ChordatesAnimal)new Squirrel();
            _section[3] = (ChordatesAnimal)new Bear();
            _section[4] = (ChordatesAnimal)new Cat();
            _section[5] = (ChordatesAnimal)new Wolf();
            _section[6] = (ChordatesAnimal)new Dog();
            _section[7] = (ChordatesAnimal)new AfricanOstrich();
            _section[8] = (ChordatesAnimal)new EmperorPeguin();
            _section[9] = (ChordatesAnimal)new Owl();
            _count = 10;
        }

        public SafariPark(ChordatesAnimal[] animals)
        {
            _section = animals;
        }

        public ChordatesAnimal[] Section
        {
            get => _section;
        }

        public void AddAnimalInSection(ChordatesAnimal animal)
        {
            if (_count <= _section.Length)
            {
                Array.Resize(ref _section, _count + 1);
            }

            _section[_count] = animal;
            _count++;
        }

        public int GetCountAnimal() => _count;
    }
}