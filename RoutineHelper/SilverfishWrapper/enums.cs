namespace SilverfishWrapper
{
    /// <summary>
    /// 卡牌类型
    /// </summary>
    public enum cardtype
    {
        NONE = 0,
        GAME = 1,
        PLAYER = 2,
        HERO = 3,//英雄
        MOB = 4,//随从
        SPELL = 5,//法术
        ENCHANTMENT = 6,//增幅（例如：变形术，救赎，力量的代价，自然之力的附加效果）
        WEAPON = 7,//武器
        ITEM = 8,
        TOKEN = 9,
        HEROPWR = 10,//英雄技能
        BLANK = 11,
        GAME_MODE_BUTTON = 12,
        MOVE_MINION_HOVER_TARGET = 22,
        LETTUCE_ABILITY,
        BATTLEGROUND_HERO_BUDDY,//战旗伙伴
        LOCATION = 39,//地标
        BATTLEGROUND_QUEST_REWARD,//战旗奖励
        BATTLEGROUND_ANOMALY = 43,//战旗畸变
        BATTLEGROUND_SPELL = 42,//战旗法术
        BATTLEGROUND_TRINKET = 44,//战旗饰品
    }

    /// <summary>
    /// 卡片效果
    /// </summary>
    public enum cardtrigers
    {
        newtriger,//新触发
        getBattlecryEffect,//战吼效果
        onAHeroGotHealedTrigger,//一个英雄受到伤害触发
        onAMinionGotHealedTrigger,//随从受到伤害触发
        onAuraEnds,//光环消失
        onAuraStarts,//光环开始
        onCardIsGoingToBePlayed,//卡片即将使用
        onCardPlay,//卡片使用
        onCardWasPlayed,//卡片使用后
        onDeathrattle,//亡语
        onEnrageStart,//激怒开始
        onEnrageStop,//激怒结束
        onMinionDiedTrigger,//随从死亡触发
        onMinionGotDmgTrigger,//随从受到伤害触发
        onMinionIsSummoned,//随从被召唤
        onMinionWasSummoned,//随从召唤过
        onSecretPlay,//奥秘使用
        onTurnEndsTrigger,//回合结束触发
        onTurnStartTrigger,//回合开始触发
        triggerInspire,//触发激发
        chaosha,//超杀
        Strike,//撞击
        xiaomie,//消灭
        onTurnStart,//回合开始
        onTurnEnd, //回合结束
        useLocation, //使用地标
    }

    /// <summary>
    /// 法术派系
    /// </summary>
    public enum SpellSchool
    {
        NONE = 0,
        ARCANE = 1, //奥术
        FIRE = 2,   //火焰
        FROST = 3,  //冰霜
        NATURE = 4, //自然
        HOLY = 5,   //神圣
        SHADOW = 6, //暗影
        FEL = 7, //邪能
        PHYSICAL_COMBAT = 8,
    }

    /// <summary>
    /// 种族
    /// </summary>
    public enum Race
    {
        INVALID = 0,
        BLOODELF = 1,
        DRAENEI = 2,
        DWARF = 3,
        GNOME = 4,
        GOBLIN = 5,
        HUMAN = 6,
        NIGHTELF = 7,
        ORC = 8,
        TAUREN = 9,
        TROLL = 10,
        UNDEAD = 11,
        WORGEN = 12,
        GOBLIN2 = 13,
        MURLOC = 14,
        DEMON = 15,
        SCOURGE = 16,
        MECHANICAL = 17,
        ELEMENTAL = 18,
        OGRE = 19,
        BEAST = 20,
        PET = 20,
        TOTEM = 21,
        NERUBIAN = 22,
        PIRATE = 23,
        DRAGON = 24,
        BLANK = 25,
        ALL = 26,
        EGG = 38,
        QUILBOAR = 43,
    }

    public enum HeroEnum
    {
        None,
        weizbang,//威兹班
        druid,		//德鲁伊
        hunter,		//猎人
        priest,		//牧师
        warlock,	//术士
        thief,		//贼
        pala,       //骑士
        warrior,	//战士
        shaman,		//萨满
        mage,		//法师
        lordjaraxxus,//大王
        ragnarosthefirelord,//炎魔
        hogger,//霍格
        demonhunter,//恶魔猎手
        deathknight,//巫妖王
    }

    /// <summary>
    /// 异常类型
    /// </summary>
    public enum ErrorType2
    {
        INVALID = -1,
        NONE = 0,
        REQ_MINION_TARGET = 1, //随从目标
        REQ_FRIENDLY_TARGET = 2, //友方目标
        REQ_ENEMY_TARGET = 3, //敌方目标
        REQ_DAMAGED_TARGET = 4, // 损伤
        REQ_MAX_SECRETS = 5, //最大奥秘
        REQ_FROZEN_TARGET = 6, //冻结
        REQ_CHARGE_TARGET = 7, //冲锋
        REQ_TARGET_MAX_ATTACK = 8, //最大攻击力，有参数
        REQ_NONSELF_TARGET = 9, //非自己
        REQ_TARGET_WITH_RACE = 10, //种族 有参数
        REQ_TARGET_TO_PLAY = 11, //小目标
        REQ_NUM_MINION_SLOTS = 12, //随从数量插槽 有参数
        REQ_WEAPON_EQUIPPED = 13, // 武器装备，需要武器
        REQ_ENOUGH_MANA = 14,
        REQ_YOUR_TURN = 15,
        REQ_NONSTEALTH_ENEMY_TARGET = 16,
        REQ_HERO_TARGET = 17,  //英雄
        REQ_SECRET_ZONE_CAP = 18,
        REQ_MINION_CAP_IF_TARGET_AVAILABLE = 19,
        REQ_MINION_CAP = 20,
        REQ_TARGET_ATTACKED_THIS_TURN = 21,
        REQ_TARGET_IF_AVAILABLE = 22, // 有目标如果用（抉择星辰降落，巫医）
        REQ_MINIMUM_ENEMY_MINIONS = 23, // 最少的敌方随从，有参数
        REQ_TARGET_FOR_COMBO = 24, //连击有目标
        REQ_NOT_EXHAUSTED_ACTIVATE = 25,
        REQ_UNIQUE_SECRET_OR_QUEST = 26,
        REQ_TARGET_TAUNTER = 27,
        REQ_CAN_BE_ATTACKED = 28,
        REQ_ACTION_PWR_IS_MASTER_PWR = 29,
        REQ_TARGET_MAGNET = 30,
        REQ_ATTACK_GREATER_THAN_0 = 31,
        REQ_ATTACKER_NOT_FROZEN = 32,
        REQ_HERO_OR_MINION_TARGET = 33,
        REQ_CAN_BE_TARGETED_BY_SPELLS = 34,
        REQ_SUBCARD_IS_PLAYABLE = 35,
        REQ_TARGET_FOR_NO_COMBO = 36,
        REQ_NOT_MINION_JUST_PLAYED = 37,
        REQ_NOT_EXHAUSTED_HERO_POWER = 38,
        REQ_CAN_BE_TARGETED_BY_OPPONENTS = 39,
        REQ_ATTACKER_CAN_ATTACK = 40,
        REQ_TARGET_MIN_ATTACK = 41, // 有参数
        REQ_CAN_BE_TARGETED_BY_HERO_POWERS = 42,
        REQ_ENEMY_TARGET_NOT_IMMUNE = 43,
        REQ_ENTIRE_ENTOURAGE_NOT_IN_PLAY = 44,
        REQ_MINIMUM_TOTAL_MINIONS = 45,//需要最少随从数量，有参数
        REQ_MUST_TARGET_TAUNTER = 46, //目标必须是嘲讽
        REQ_UNDAMAGED_TARGET = 47, //目标未受伤
        REQ_CAN_BE_TARGETED_BY_BATTLECRIES = 48,
        REQ_STEADY_SHOT = 49,
        REQ_MINION_OR_ENEMY_HERO = 50,
        REQ_TARGET_IF_AVAILABLE_AND_DRAGON_IN_HAND = 51, // 有龙牌在手
        REQ_LEGENDARY_TARGET = 52,
        REQ_FRIENDLY_MINION_DIED_THIS_TURN = 53,  // 需要一个死亡的友方随从在当前回合死亡
        REQ_FRIENDLY_MINION_DIED_THIS_GAME = 54,  //需要一个死亡的友方随从
        REQ_ENEMY_WEAPON_EQUIPPED = 55,
        REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_MINIONS = 56,
        REQ_TARGET_WITH_BATTLECRY = 57,
        REQ_TARGET_WITH_DEATHRATTLE = 58,
        REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_FRIENDLY_SECRETS = 59,
        REQ_SECRET_ZONE_CAP_FOR_NON_SECRET = 60,
        REQ_TARGET_EXACT_COST = 61,
        REQ_STEALTHED_TARGET = 62,
        REQ_MINION_SLOT_OR_MANA_CRYSTAL_SLOT = 63,
        REQ_MAX_QUESTS = 64,
        REQ_TARGET_IF_AVAILABE_AND_ELEMENTAL_PLAYED_LAST_TURN = 65,
        REQ_TARGET_NOT_VAMPIRE = 66,
        REQ_TARGET_NOT_DAMAGEABLE_ONLY_BY_WEAPONS = 67,
        REQ_NOT_DISABLED_HERO_POWER = 68,
        REQ_MUST_PLAY_OTHER_CARD_FIRST = 69,
        REQ_HAND_NOT_FULL = 70,
        REQ_DRAG_TO_PLAY = 71,
        REQ_TARGET_TO_PLAY2 = 75,
        REQ_TARGET_NO_NATURE = 77,
        REQ_LITERALLY_UNPLAYABLE,
        REQ_TARGET_IF_AVAILABLE_AND_HERO_HAS_ATTACK,
        REQ_FRIENDLY_MINION_OF_RACE_DIED_THIS_TURN,
        REQ_TARGET_IF_AVAILABLE_AND_MINIMUM_SPELLS_PLAYED_THIS_TURN,
        REQ_FRIENDLY_MINION_OF_RACE_IN_HAND,
        REQ_FRIENDLY_DEATHRATTLE_MINION_DIED_THIS_GAME = 86,
        REQ_FRIENDLY_REBORN_MINION_DIED_THIS_GAME = 89,
        REQ_MINION_DIED_THIS_GAME,
        REQ_BOARD_NOT_COMPLETELY_FULL = 92,
        REQ_TARGET_IF_AVAILABLE_AND_HAS_OVERLOADED_MANA,
        REQ_TARGET_IF_AVAILABLE_AND_HERO_ATTACKED_THIS_TURN,
        REQ_TARGET_IF_AVAILABLE_AND_DRAWN_THIS_TURN,
        REQ_TARGET_IF_AVAILABLE_AND_NOT_DRAWN_THIS_TURN,
        REQ_TARGET_NON_TRIPLED_MINION,
        REQ_BOUGHT_MINION_THIS_TURN,
        REQ_SOLD_MINION_THIS_TURN,
        REQ_TARGET_IF_AVAILABLE_AND_PLAYER_HEALTH_CHANGED_THIS_TURN,
        REQ_TARGET_IF_AVAILABLE_AND_SOUL_FRAGMENT_IN_DECK,
        REQ_DAMAGED_TARGET_UNLESS_COMBO,
        REQ_NOT_MINION_DORMANT,
        REQ_TARGET_NOT_UNTOUCHABLE,
        REQ_TARGET_IF_AVAILABLE_AND_BOUGHT_RACE_THIS_TURN,
        REQ_TARGET_IF_AVAILABLE_AND_SOLD_RACE_THIS_TURN,
        REQ_NOT_IN_COOLDOWN,
        REQ_TARGET_IS_MERC,
        REQ_TARGET_IS_NON_MERC,
        REQ_TWO_OF_A_KIND,
        REQ_HAS_OVERLOADED_MANA,
        REQ_LETTUCE_ABILITY_CANNOT_TARGET_OWNER,
        REQ_TARGET_NOT_HAVE_TAG = 116,
        REQ_TARGET_MUST_HAVE_TAG,
        REQ_TRADEABLE = 119,
        REQ_NOT_LEGENDARY_TARGET = 123,
        REQ_MINIMUM_TAVERN_TIER_LEVEL_TO_PLAY = 128,
        REQ_CARD_TAVERN_TIER_LEVEL_TO_PLAY,
        REQ_NOT_EXHAUSTED_LOCATION,
        REQ_LOCATION_TARGET,
        REQ_TARGET_SILVER_HAND_RECRUIT,
        REQ_MINIMUM_CORPSES,
        REQ_LOCATION_OR_MINION_TARGET,
        REQ_CAN_BE_TARGETED_BY_LOCATIONS,
        REQ_FORGE,
        REQ_TARGET_MAX_COST,
        REQ_HAS_PLAYED_SPELL_THIS_GAME,
        REQ_TARGET_IS_NON_TITAN = 141,
        REQ_BACON_DUO_PASSABLE,
        REQ_TARGET_EXACT_ATTACK,
        REQ_MINIMUM_NON_GOLDEN_ENEMY_MINIONS = 146,
    }

    public enum actionEnum
    {
        endturn = 0, //结束此回合
        playcard, //出一张卡牌，出的牌在card中
        attackWithHero, //英雄进行攻击，target作为目标，own通常是我方英雄
        useHeroPower, //使用英雄技能，target作为目标 (英雄技能无攻击目标的英雄则为null，如Mage)
        attackWithMinion, //随从进行攻击，target作为目标，own是用于攻击的随从
        trade, //交易
        useLocation, //使用地标
        useTitanAbility, //使用泰坦技能
        forge, //锻造
    }
}
