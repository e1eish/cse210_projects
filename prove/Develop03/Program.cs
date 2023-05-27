using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("Matthew", 5, 14, 16);
        Scripture scripture1 = new Scripture("14 Ye are the light of the world. A city that is set on an hill cannot be hid.\n15 Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house.\n16 Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.", reference1);
        
        Reference referece2 = new Reference("2 Nephi", 32, 3);
        Scripture scripture2 = new Scripture("3 Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.", referece2);

        Reference reference3 = new Reference("John", 17, 3);
        Scripture scripture3 = new Scripture("3 And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.", reference3);

        Reference reference4 = new Reference("Alma", 7, 11, 13);
        Scripture scripture4 = new Scripture("11 And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.\n12 And he will take upon him death, that he may loose the bands of death which bind his people; and he will take upon him their infirmities, that his bowels may be filled with mercy, according to the flesh, that he may know according to the flesh how to succor his people according to their infirmities.\n13 Now the Spirit knoweth all things; nevertheless the Son of God suffereth according to the flesh that he might take upon him the sins of his people, that he might blot out their transgressions according to the power of his deliverance; and now behold, this is the testimony which is in me.", reference4);

        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(scripture1);
        scriptures.Add(scripture2);
        scriptures.Add(scripture3);
        scriptures.Add(scripture4);

        Random rand = new Random();
        int scriptureIndex = rand.Next(scriptures.Count());

        Menu menu = new Menu(scriptures[scriptureIndex]);
        menu.Display();
    }
}