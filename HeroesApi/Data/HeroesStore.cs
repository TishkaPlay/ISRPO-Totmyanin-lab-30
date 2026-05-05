using HeroesApi.Models;

namespace HeroesApi.Data;

public static class HeroesStore {
    public static List<Hero> Heroes { get; } = new List<Hero> {
        new Hero {
            Id = 1,
            Name = "Человек-паук",
            RealName = "Питер Паркер",
            Universe = Universe.Marvel,
            PowerLevel = 75,
            Powers = new List<string> { "Паутина", "Лазанье по стенам", "Паучье чутье" },
            Weapon = new Weapon { Name = "Паутинострел", IsRanged = true },
            InternalNotes = "Любимый герой редактора"
    },

    new Hero {
        Id = 2,
        Name = "Бэтмен",
        RealName = "Брюс Уэйн",
        Universe = Universe.Dc,
        PowerLevel = 70,
        Powers = new List<string> { "Интеллект", "Боевые искусства", "Технологии" },
        Weapon = new Weapon { Name = "Бэтаранг", IsRanged = true },
        InternalNotes = "Без суперсил, только деньги и упорство"
    },

    new Hero {
        Id = 3,
        Name = "Железный человек",
        RealName = "Тони Старк",
        Universe = Universe.Marvel,
        PowerLevel = 85,
        Powers = new List<string> { "Броня", "Интеллект", "Полет", "Лазеры" },
        Weapon = new Weapon { Name = "Костюм Марк 50", IsRanged = true },
        InternalNotes = "Я - Железный человек"
    },
    new Hero {
        Id = 4,
        Name = "Грут",
        RealName = "Грут",
        Universe = Universe.Marvel,
        PowerLevel = 80,
        Powers = new List<string> { "Регенерация", "Управление деревом", "Суперсила" },
        Weapon = new Weapon { Name = "Ветви", IsRanged = false },
        InternalNotes = "Я есть Грут"
    },

    new Hero {
        Id = 5,
        Name = "Тор",
        RealName = "Тор Одинсон",
        Universe = Universe.Marvel,
        PowerLevel = 95,
        Powers = new List<string> { "Молния", "Полет", "Суперсила", "Бессмертие" },
        Weapon = new Weapon { Name = "Мьёльнир", IsRanged = false },
        InternalNotes = "Бог грома"
    },
    new Hero {
        Id = 6,
        Name = "Росомаха",
        RealName = "Логан",
        Universe = Universe.Marvel,
        PowerLevel = 85,
        Powers = new List<string> { "Регенирация", "Когти", "Суперсила", "Замедленное старение" },
        Weapon = new Weapon { Name = "Адамантиевые когти", IsRanged = false },
      InternalNotes = "Лучший у меня есть."
    },
    new Hero {
        Id = 7,
        Name = "Дэдпул",
        RealName = "Уэёд Уилсон",
        Universe = Universe.Marvel,
        PowerLevel = 80,
        Powers = new List<string> { "Регенирация", "Владение оружием", "Болтовня" },
      Weapon = new Weapon { Name = "Катаны и пистолеты", IsRanged = true },
      InternalNotes = "Разрушает червёртую стену"
    }
  };
}