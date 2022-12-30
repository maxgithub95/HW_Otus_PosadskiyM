using System.Collections.Immutable;

namespace HW_12_Jack
{

    public class Part1
    {
        public ImmutableList<string> Poem { get; set; }
        public ImmutableList<string> AddPart(ImmutableList<string> part)
        {
            return Poem = part.AddRange(new List<string> { "Вот дом,", "Который построил Джек.\n" });
        }
    }
    public class Part2
    {
        public ImmutableList<string> Poem { get; set; }
        public ImmutableList<string> AddPart(ImmutableList<string> part)
        {

            return Poem = part.AddRange(new List<string> { "А это пшеница,", "Которая в темном чулане хранится",
                                                           "В доме,", "Который построил Джек.\n"});

        }
    }
    public class Part3
    {
        public ImmutableList<string> Poem { get; set; }
        public ImmutableList<string> AddPart(ImmutableList<string> part)
        {
            return Poem = part.AddRange(new List<string> { "А это веселая птица-синица,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
                                                           "В доме,", "Который построил Джек.\n"});

        }
    }
    public class Part4
    {
        public ImmutableList<string> Poem { get; set; }
        public ImmutableList<string> AddPart(ImmutableList<string> part)
        {
            return Poem = part.AddRange(new List<string> { "Вот кот,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
                                                           "В доме,", "Который построил Джек.\n"});

        }
    }
    public class Part5
    {
        public ImmutableList<string> Poem { get; set; }
        public ImmutableList<string> AddPart(ImmutableList<string> part)
        {
            return Poem = part.AddRange(new List<string> { "Вот пес без хвоста,", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,",
                                                        "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
                                                           "В доме,", "Который построил Джек.\n"});

        }
    }
    public class Part6
    {
        public ImmutableList<string> Poem { get; set; }
        public ImmutableList<string> AddPart(ImmutableList<string> part)
        {
            return Poem = part.AddRange(new List<string> { "А это корова безрогая,", "Лягнувшая старого пса без хвоста,", "Который за шиворот треплет кота,",
                                                            "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
                                                           "В доме,", "Который построил Джек.\n"});

        }
    }
    public class Part7
    {
        public ImmutableList<string> Poem { get; set; }
        public ImmutableList<string> AddPart(ImmutableList<string> part)
        {
            return Poem = part.AddRange(new List<string> { "А это старушка, седая и строгая,", "Которая доит корову безрогую,", "Лягнувшая старого пса без хвоста,",
                                                    "Который за шиворот треплет кота,", "Который пугает и ловит синицу,", "Которая часто ворует пшеницу,",
                                                        "Которая в темном чулане хранится", "В доме,", "Который построил Джек.\n"});

        }
    }
    public class Part8
    {
        public ImmutableList<string> Poem { get; set; }
        public ImmutableList<string> AddPart(ImmutableList<string> part)
        {
            return Poem = part.AddRange(new List<string> { "А это ленивый и толстый пастух,", "Который бранится с коровницей строгою,", "Которая доит корову безрогую,",
                                                    "Лягнувшая старого пса без хвоста,", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,",
                                                       "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
                                                           "В доме,", "Который построил Джек.\n"});

        }
    }
    public class Part9
    {
        public ImmutableList<string> Poem { get; set; }
        public ImmutableList<string> AddPart(ImmutableList<string> part)
        {
            return Poem = part.AddRange(new List<string> { "Вот два петуха,", "Которые будят того пастуха,", "Который бранится с коровницей строгою,", "Которая доит корову безрогую,",
                                                    "Лягнувшая старого пса без хвоста,", "Который за шиворот треплет кота,", "Который пугает и ловит синицу,",
                                                       "Которая часто ворует пшеницу,", "Которая в темном чулане хранится",
                                                           "В доме,", "Который построил Джек."});

        }
    }
}

