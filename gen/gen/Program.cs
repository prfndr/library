﻿using System;
using System.IO;

namespace ConsoleApp20
{
    class Program
    {
        static string Genword()
        {
            Random rand = new Random();
            string word = "";
            for (int i = 0; i < 5; i++)
            {
                word += (char)rand.Next(0x0410, 0x44F);
            }
            return word;
        }

        static void Main(string[] args)
        {
            string path = @"D:\Рабочий стол\субд\1 семак\лр1\lib1.txt";
            Random rand = new Random();
            string[] x = new string[] { "мягкий", "твердый" };
            string[] y = new string[] { "покупка", "подарок", "наследство" };
            string[] z = new string[] { "детектив", "фантастика", "приключения", "роман", "научная книга", "фольклор", "юмор", "справочная книга", "проза", "детская книга", "документальная литература", "деловая литература", "религиозная литература", "учебная книга", "книга о психологии", "хобби", "зарубежная литература", "техника" };
            string[] b = new string[] {"Федор Достоевский",
"Михаил Булгаков",
"Александр Пушкин",
"Лев Толстой",
"Николай Гоголь",
"Антон Чехов",
"Александр Дюма",
"Иван Тургенев",
"Илья Ильф, Евгений Петров",
"Эрих Мария Ремарк",
"Артур Конан Дойль",
"Аркадий и Борис Стругацкие",
"Виктор Гюго",
"Жюль Верн",
"Джек Лондон",
"Михаил Шолохов",
"Эрнест Хемингуэй",
"Алексей Толстой",
"Агата Кристи",
"Михаил Лермонтов",
"Александр Грибоедов",
"Валентин Пикуль",
"Марк Твен",
"Даниель Дефо",
"Николай Лесков",
"Иван Гончаров",
"Уильям Шекспир",
"Александр Волков",
"Николай Носов",
"Борис Васильев",
"Максим Горький",
"Василь Быков",
"Александр Беляев",
"Александр Грин",
"Василий Шукшин",
"Станислав Лем",
"Шарлотта Бронте",
"Юрий Поляков",
"Вениамин Каверин",
"Аркадий Гайдар",
"Джордж Оруэлл",
"Иван Шмелёв",
"Рэй Брэдбери",
"Пауло Коэльо",
"Валентин Катаев",
"Владимир Обручев",
"Александр Куприн",
"Константин Симонов",
"Иван Ефремов",
"Томас Манн",
"Александр Островский",
"Леонид Филатов",
"Борис Пастернак",
"Григорий Белых, Л. Пантелеев",
"Иоганн Вольфганг фон Гёте",
"Юлиан Семенов",
"Герман Гессе",
"Братья Вайнеры",
"Габриэль Гарсиа Маркес",
"Анатолий Рыбаков",
"Сергей Алексеев",
"Фрэнсис Скотт Фицджеральд",
"Евгений Шварц",
"Герберт Уэллс",
"Льюис Кэрролл",
"Николай Некрасов",
"Владимир Богомолов",
"Харуки Мураками",
"Сергей Есенин",
"Теодор Драйзер",
"Оскар Уайльд",
"Александр Вампилов",
"Роберт Льюис Стивенсон",
"Михаил Салтыков-Щедрин",
"Кен Кизи",
"Константин Паустовский",
"Антуан де Сент-Экзюпери",
"Франц Кафка",
"Ганс Христиан Андерсен",
"Виктор Драгунский",
"Александр Блок",
"Иван Бунин",
"Иван Крылов",
"Ярослав Гашек",
"Валентин Распутин",
"Гавриил Троепольский",
"Редьярд Киплинг",
"Джейн Остин",
"Лев Кассиль",
"Стендаль",
"Чарльз Диккенс",
"Джонатан Свифт",
"Кир Булычев",
"Антон Макаренко",
"Джером Д. Сэлинджер",
"Маргарет Митчелл",
"Гомер",
"Мария Семенова",
"Корней Чуковский",
"Евгений Замятин"};

            string[] sysh = new string[] {"год",
"человек",
"время",
"дело",
"жизнь",
"день",
"рука",
"раз",
"работа",
"слово",
"место",
"лицо",
"друг",
"глаз",
"вопрос",
"дом",
"сторона",
"страна",
"мир",
"случай",
"голова",
"ребенок",
"сила",
"конец",
"вид",
"система",
"часть",
"город",
"отношение",
"женщина",
"деньги",
"земля",
"машина",
"вода",
"отец",
"проблема",
"час",
"право",
"нога",
"решение",
"дверь",
"образ",
"история",
"власть",
"закон",
"война",
"бог",
"голос",
"тысяча",
"книга",
"возможность",
"результат",
"ночь",
"стол",
"имя",
"область",
"статья",
"число",
"компания",
"народ",
"жена",
"группа",
"развитие",
"процесс",
"суд",
"условие",
"средство",
"начало",
"свет",
"пора",
"путь",
"душа",
"уровень",
"форма",
"связь",
"минута",
"улица",
"вечер",
"качество",
"мысль",
"дорога",
"мать",
"действие",
"месяц",
"государство",
"язык",
"любовь",
"взгляд",
"мама",
"век",
"школа",
"цель",
"общество",
"деятельность",
"организация",
"президент",
"комната",
"порядок",
"момент",
"театр",
"письмо",
"утро",
"помощь",
"ситуация",
"роль",
"рубль",
"смысл",
"состояние",
"квартира",
"орган",
"внимание",
"тело",
"труд",
"сын",
"мера",
"смерть",
"рынок",
"программа",
"задача",
"предприятие",
"окно",
"разговор",
"правительство",
"семья",
"производство",
"информация",
"положение",
"центр",
"ответ",
"муж",
"автор",
"стена",
"интерес",
"федерация",
"правило",
"управление",
"мужчина",
"идея",
"партия",
"совет",
"счет",
"сердце",
"движение",
"вещь",
"материал",
"неделя",
"чувство",
"глава",
"наука",
"ряд",
"газета",
"причина",
"плечо",
"цена",
"план",
"речь",
"точка",
"основа",
"товарищ",
"культура",
"данные",
"мнение",
"документ",
"институт",
"ход",
"проект",
"встреча",
"директор",
"срок",
"палец",
"опыт",
"служба",
"судьба",
"девушка",
"очередь",
"лес",
"состав",
"член",
"количество",
"событие",
"объект",
"зал",
"создание",
"значение",
"период",
"шаг",
"брат",
"искусство",
"структура",
"номер",
"пример",
"исследование",
"гражданин",
"игра",
"начальник",
"рост",
"тема",
"принцип",
"метод",
"тип",
"фильм",
"край",
"гость",
"воздух",
"характер",
"борьба",
"использование",
"размер",
"образование",
"мальчик",
"кровь",
"район",
"небо",
"армия",
"класс",
"представитель",
"участие",
"девочка",
"политика",
"герой",
"картина",
"доллар",
"спина",
"территория",
"пол",
"поле",
"изменение",
"направление",
"рисунок",
"течение",
"церковь",
"банк",
"сцена",
"население",
"большинство",
"музыка",
"правда",
"свобода",
"память",
"команда",
"союз",
"врач",
"договор",
"дерево",
"факт",
"хозяин",
"природа",
"угол",
"телефон",
"позиция",
"двор",
"писатель",
"самолет",
"объем",
"род",
"солнце",
"вера",
"берег",
"спектакль",
"фирма",
"способ",
"завод",
"цвет",
"журнал",
"руководитель",
"специалист",
"оценка",
"регион",
"песня",
"процент",
"родитель",
"море",
"требование",
"основание",
"половина",
"роман",
"круг",
"анализ",
"стихи",
"автомобиль",
"экономика",
"литература",
"бумага",
"поэт",
"степень",
"господин",
"надежда",
"предмет",
"вариант",
"министр",
"граница",
"дух",
"модель",
"операция",
"пара",
"сон",
"название",
"ум",
"повод",
"старик",
"миллион",
"успех",
"счастье",
"ребята",
"кабинет",
"магазин",
"пространство",
"выход",
"удар",
"база",
"знание",
"текст",
"защита",
"руководство",
"площадь",
"сознание",
"возраст",
"участник",
"участок",
"пункт",
"линия",
"желание",
"папа",
"доктор",
"губа",
"дочь",
"среда",
"председатель",
"представление",
"солдат",
"художник",
"волос",
"оружие",
"соответствие",
"ветер",
"парень",
"зрение",
"генерал",
"огонь",
"понятие",
"строительство",
"ухо",
"грудь",
"нос",
"страх",
"услуга",
"содержание",
"радость",
"безопасность",
"продукт",
"комплекс",
"бизнес",
"сад",
"сотрудник",
"лето",
"курс",
"предложение",
"рот",
"технология",
"реформа",
"отсутствие",
"собака",
"камень",
"будущее",
"рассказ",
"контроль",
"река",
"продукция",
"сумма",
"техника",
"здание",
"сфера",
"необходимость",
"фонд",
"подготовка",
"лист",
"республика",
"хозяйство",
"воля",
"бюджет",
"снег",
"деревня",
"мужик",
"элемент",
"обстоятельство",
"немец",
"победа",
"источник",
"звезда",
"выбор",
"масса",
"итог",
"сестра",
"практика",
"проведение",
"карман",
"слава",
"кухня",
"определение",
"функция",
"войско",
"комиссия",
"применение",
"капитан",
"работник",
"обеспечение",
"офицер",
"фамилия",
"предел",
"выборы",
"ученый",
"бутылка",
"бой",
"теория",
"зона",
"отдел",
"зуб",
"разработка",
"личность",
"гора",
"товар",
"метр",
"праздник",
"влияние",
"читатель",
"удовольствие",
"актер",
"слеза",
"ответственность",
"учитель",
"акт",
"боль",
"множество",
"особенность",
"показатель",
"корабль",
"звук",
"впечатление",
"частность",
"детство",
"вывод",
"профессор",
"доля",
"норма",
"прошлое",
"командир",
"коридор",
"поддержка",
"рамка",
"враг",
"этап",
"черт",
"дед",
"собрание",
"прием",
"болезнь",
"клетка",
"кожа",
"заявление",
"попытка",
"сравнение",
"расчет",
"депутат",
"комитет",
"знак",
"дядя",
"учет",
"хлеб",
"чай",
"режим",
"целое",
"вирус",
"выражение",
"здоровье",
"зима",
"десяток",
"глубина",
"сеть",
"студент",
"секунда",
"скорость",
"поиск",
"суть",
"налог",
"ошибка",
"доход",
"режиссер",
"поверхность",
"ощущение",
"карта",
"клуб",
"станция",
"революция",
"колено",
"министерство",
"стекло",
"этаж",
"высота",
"бабушка",
"трубка",
"газ",
"мастер",
"поведение",
"столица",
"механизм",
"передача",
"способность",
"подход",
"энергия",
"существование",
"исполнение",
"кино",
"сожаление",
"заместитель",
"ресурс",
"акция",
"рождение",
"администрация",
"стоимость",
"улыбка",
"артист",
"сосед",
"фраза",
"фигура",
"субъект",
"реакция",
"список",
"фотография",
"журналист",
"май",
"нарушение",
"заседание",
"толпа",
"больница",
"существо",
"свойство",
"долг",
"поколение",
"животное",
"схема",
"усилие",
"отличие",
"остров",
"противник",
"волна",
"реализация",
"страница",
"формирование",
"житель",
"красота",
"птица",
"растение",
"тень",
"явление",
"храм",
"запах",
"водка",
"наличие",
"ужас",
"одежда",
"кресло",
"больной",
"поезд",
"университет",
"традиция",
"адрес",
"декабрь",
"ладонь",
"сведение",
"цветок",
"лидер",
"октябрь",
"занятие",
"сентябрь",
"помещение",
"январь",
"зритель",
"редакция",
"стиль",
"весна",
"фактор",
"август",
"известие",
"зависимость",
"охрана",
"оборудование",
"концерт",
"отделение",
"расход",
"выставка",
"милиция",
"переход",
"эпоха",
"запад",
"произведение",
"родина",
"собственность",
"тайна",
"трава",
"лагерь",
"имущество",
"кровать",
"аппарат",
"середина",
"март",
"клиент",
"дама",
"фронт",
"отрасль",
"стул",
"беседа",
"законодательство",
"продажа",
"повышение",
"музей",
"след",
"полковник",
"сомнение",
"понимание",
"апрель",
"князь",
"рыба",
"дума",
"кодекс",
"сутки",
"чудо",
"шея",
"судья",
"крыша",
"настроение",
"поток",
"должность",
"преступление",
"мозг",
"честь",
"пост",
"еврей",
"июнь",
"сотня",
"дождь",
"лестница",
"дача",
"установка",
"появление",
"получение",
"образец",
"труба",
"главное",
"осень",
"костюм",
"баба",
"ценность",
"обязанность",
"пьеса",
"таблица",
"вино",
"воспоминание",
"лошадь",
"коллега",
"организм",
"ученик",
"учреждение",
"открытие",
"том",
"черта",
"характеристика",
"выполнение",
"оборона",
"выступление",
"температура",
"перспектива",
"подруга",
"приказ",
"жертва",
"ресторан",
"километр",
"спор",
"вкус",
"признак",
"промышленность",
"американец",
"лоб",
"заключение",
"восток",
"исключение",
"ключ",
"постановление",
"слой",
"бок",
"июль",
"перевод",
"секретарь",
"кусок",
"слух",
"польза",
"звонок",
"обстановка",
"чиновник",
"соглашение",
"деталь",
"русский",
"тишина",
"зарплата",
"билет",
"подарок",
"тюрьма",
"ящик",
"конкурс",
"книжка",
"изучение",
"просьба",
"царь",
"публика",
"смех",
"сообщение",
"угроза",
"беда",
"блок",
"достижение",
"назначение",
"реклама",
"портрет",
"масло",
"стакан",
"урок",
"часы",
"крик",
"творчество",
"телевизор",
"инструмент",
"концепция",
"лейтенант",
"экран",
"дно",
"реальность",
"канал",
"мясо",
"знакомый",
"щека",
"конфликт",
"переговоры",
"запись",
"вагон",
"площадка",
"последствие",
"сотрудничество",
"зеркало",
"тон",
"академия",
"палата",
"потребность",
"ноябрь",
"увеличение",
"дурак",
"поездка",
"обед",
"потеря",
"февраль",
"мероприятие",
"парк",
"принятие",
"устройство",
"вещество",
"категория",
"сезон",
"гостиница",
"издание",
"объединение",
"темнота",
"человечество",
"колесо",
"опасность",
"разрешение",
"воздействие",
"коллектив",
"камера",
"запас",
"следствие",
"длина",
"крыло",
"округ",
"фон",
"кандидат",
"родственник",
"давление",
"присутствие",
"взаимодействие",
"доска",
"партнер",
"двигатель",
"шум",
"достоинство",
"грех",
"нож",
"полет",
"страсть",
"испытание",
"TRUE",
"оплата",
"разница",
"водитель",
"пакет",
"снижение",
"формула",
"живот",
"капитал",
"мост",
"новость",
"эффект",
"вход",
"губернатор",
"доклад",
"смена",
"убийство",
"эксперт",
"автобус",
"платье",
"кадр",
"тетя",
"общение",
"психология",
"лев",
"порог",
"проверка",
"процедура",
"рабочий",
"ремонт",
"обращение",
"обучение",
"ожидание",
"памятник",
"корень",
"наблюдение",
"буква",
"доказательство",
"признание",
"постель",
"штаб",
"владелец",
"компьютер",
"инженер",
"старуха",
"лодка",
"ракета",
"серия",
"шутка",
"вершина",
"выпуск",
"кулак",
"лед",
"торговля",
"нефть",
"молодежь",
"цифра",
"корпус",
"недостаток",
"сапог",
"сущность",
"талант",
"эффективность",
"кофе",
"полоса",
"основное",
"рассмотрение",
"сбор",
"штат",
"следователь",
"жилье",
"мешок",
"описание",
"куст",
"отказ",
"замок",
"редактор",
"дворец",
"забота",
"пиво",
"диван",
"столик",
"эксперимент",
"печать",
"кольцо",
"пистолет",
"воспитание",
"начальство",
"профессия",
"ворота",
"добро",
"дружба",
"покой",
"риск",
"окончание",
"дым",
"брак",
"величина",
"записка",
"инициатива",
"совесть",
"активность",
"кость",
"спорт",
"кредит",
"господь",
"майор",
"конференция",
"потолок",
"библиотека",
"помощник",
"конструкция",
"отдых",
"ручка",
"металл",
"молоко",
"прокурор",
"транспорт",
"поэзия",
"соединение",
"краска",
"расстояние",
"мечта",
"село",
"еда",
"зло",
"подразделение",
"сюжет",
"рубеж",
"сигнал",
"атмосфера",
"крест",
"вес",
"взрыв",
"контакт",
"сигарета",
"восторг",
"золото",
"почва",
"премия",
"король",
"подъезд",
"шанс",
"автомат",
"заказ",
"мальчишка",
"очки",
"миг",
"штука",
"чтение",
"поселок",
"свидетель",
"ставка",
"сумка",
"удивление",
"хвост",
"песок",
"поворот",
"возвращение",
"мгновение",
"статус",
"озеро",
"строй",
"параметр",
"сказка",
"тенденция",
"вина",
"дыхание",
"версия",
"масштаб",
"монастырь",
"хозяйка",
"дочка",
"танец",
"эксплуатация",
"коммунист",
"пенсия",
"приятель",
"объяснение",
"набор",
"производитель",
"пыль",
"философия",
"мощность",
"обязательство",
"уход",
"горло",
"кризис",
"указание",
"плата",
"яблоко",
"препарат",
"действительность",
"москвич",
"остаток",
"изображение",
"сделка",
"сочинение",
"покупатель",
"танк",
"затрата",
"строка",
"единица" };
            string[] pril = new string[] {"абсолютный",
"адский",
"азартный",
"активный",
"ангельский",
"антагонистический",
"арктический",
"астрономический",
"баснословный",
"безапелляционный",
"безбожный",
"безбрежный",
"безвозвратный",
"безграничный",
"бездонный",
"бездушный",
"безжалостный",
"беззаветный",
"беззастенчивый",
"безмерный",
"безмятежный",
"безнадежный",
"безоговорочный",
"безотлагательный",
"безраздельный",
"безрассудный",
"безропотный",
"безудержный",
"безукоризненный",
"безумный",
"безупречный",
"безусловный",
"безустанный",
"безутешный",
"безысходный",
"белоснежный",
"бескомпромиссный",
"бесконечный",
"беспардонный",
"бесповоротный",
"беспощадный",
"беспредельный",
"беспрекословный",
"беспрецедентный",
"беспримерный",
"беспробудный",
"беспроглядный",
"беспросветный",
"беспросыпный",
"бессовестный",
"бесстыдный",
"бесценный",
"бесчеловечный",
"бесчисленный",
"бесшабашный",
"бешеный",
"блестящий",
"богатый",
"богатырский",
"большой",
"буйный",
"бурный",
"варварский",
"великий",
"величайший",
"веский",
"весомый",
"внушительный",
"возмутительный",
"волчий",
"вопиющий",
"восторженный",
"впечатляющий",
"всемерный",
"всепоглощающий",
"всесильный",
"всесторонний",
"всяческий",
"выдающийся",
"вылитый",
"высокий",
"высший",
"галопирующий",
"гибельный",
"гигантский",
"глубокий",
"глубочайший",
"глухой",
"головокружительный",
"гомерический",
"горький",
"горючий",
"горячий",
"грандиозный",
"гробовой",
"грозный",
"громадный",
"громкий",
"громоподобный",
"грубый",
"густой",
"диаметральный",
"дивный",
"дикий",
"добрый",
"доскональный",
"дотошный",
"дремучий",
"душераздирающий",
"дьявольский",
"жаркий",
"жгучий",
"железный",
"жесткий",
"жестокий",
"жесточайший",
"живой",
"животный",
"жизненный",
"жуткий",
"завзятый",
"завидный",
"закадычный",
"заклятый",
"законченный",
"закоренелый",
"замечательно",
"замечательный",
"записной",
"запредельный",
"заядлый",
"звериный",
"зверский",
"зеленый",
"злой",
"злостный",
"значительный",
"идеальный",
"излишний",
"изрядный",
"изуверский",
"изумительный",
"исключительный",
"исполинский",
"исступленный",
"истинно",
"истинный",
"истовый",
"истошный",
"исчерпывающий",
"каменный",
"кардинальный",
"катастрофический",
"категорический",
"клятвенный",
"колоссальный",
"коренной",
"космический",
"крайний",
"крепкий",
"кристальный",
"кричащий",
"кровный",
"кромешный",
"круглый",
"крупный",
"крутой",
"леденящий",
"лошадиный",
"лютый",
"максимальный",
"массовый",
"маститый",
"матерый",
"махровый",
"мертвенно",
"мертвенный",
"мертвецкий",
"мертвый",
"мировой",
"могильный",
"могучий",
"молниеносный",
"мощный",
"мучительный",
"набитый",
"наглый",
"наглядный",
"надежный",
"надрывный",
"наибольший",
"наивысший",
"нарочитый",
"настоятельный",
"настоящий",
"насущный",
"небывалый",
"невероятный",
"невиданный",
"невозможный",
"невообразимый",
"невосполнимый",
"невыносимый",
"невыразимый",
"недопустимый",
"недосягаемый",
"недюжинный",
"незабываемый",
"незаурядный",
"неземной",
"неизбывный",
"неизмеримый",
"неимоверный",
"неиссякаемый",
"неистовый",
"неистощимый",
"неистребимый",
"неисходный",
"неисчерпаемый",
"неисчислимый",
"немаловажный",
"немалый",
"немилосердный",
"немой",
"немыслимый",
"ненасытный",
"необоримый",
"необузданный",
"необыкновенный",
"необычайный",
"неограниченный",
"неодолимый",
"неописуемый",
"неопровержимый",
"неоспоримый",
"неотразимый",
"неоценимый",
"непередаваемый",
"непереносимый",
"непобедимый",
"неповторимый",
"непогрешимый",
"неподдельный",
"непоколебимый",
"непомерный",
"непоправимый",
"непостижимый",
"непревзойденный",
"непреоборимый",
"непреодолимый",
"непререкаемый",
"непримиримый",
"непробиваемый",
"непробудный",
"непроглядный",
"непролазный",
"непроходимый",
"неразрывный",
"нерасторжимый",
"несгибаемый",
"несказанный",
"неслыханный",
"несметный",
"несмолкаемый",
"несмываемый",
"несокрушимый",
"несравненный",
"нестерпимый",
"несусветный",
"неудержимый",
"неуемный",
"неуклонный",
"неукоснительный",
"неукротимый",
"неумеренный",
"неустанный",
"неусыпный",
"неутешный",
"неутолимый",
"неутомимый",
"нечеловеческий",
"нешуточный",
"нещадный",
"обильный",
"обложной",
"образцовый",
"оглушительный",
"огромный",
"ожесточенный",
"олимпийский",
"ослепительный",
"ослиный",
"основательный",
"остервенелый",
"острый",
"отборный",
"откровенный",
"открытый",
"отличный",
"отменный",
"отпетый",
"отчаянный",
"отъявленный",
"ошеломляющий",
"панический",
"патологический",
"первейший",
"первоклассный",
"первый",
"пламенный",
"плотный",
"площадной",
"повальный",
"поголовный",
"подавляющий",
"подлинный",
"подчеркнутый",
"полнейший",
"полный",
"поразительный",
"порядочный",
"последний",
"потрясающий",
"предельный",
"преклонный",
"преступный",
"приличный",
"принципиальный",
"прирожденный",
"прожженный",
"проливной",
"пронзительный",
"пронизывающий",
"прямой",
"пущий",
"пьянящий",
"рабский",
"радикальный",
"разгромный",
"раздирающий",
"разительный",
"разящий",
"райский",
"ревностный",
"революционный",
"редкий",
"редкостный",
"резкий",
"рекордный",
"решительный",
"рьяный",
"сатанинский",
"сверхчеловеческий",
"сверхъестественный",
"свинцовый",
"свирепый",
"седой",
"сердитый",
"серьезный",
"сильный",
"сказочно",
"сказочный",
"слепой",
"смертельный",
"смертный",
"сногсшибательный",
"собачий",
"совершеннейший",
"совершенный",
"сокрушительный",
"солидный",
"сплошной",
"стальной",
"стоический",
"стойкий",
"стопроцентный",
"страстный",
"страшный",
"строгий",
"строжайший",
"сумасшедший",
"суровый",
"существенный",
"сущий",
"твердый",
"телячий",
"титанический",
"тотальный",
"трескучий",
"триумфальный",
"тяжелый",
"тяжкий",
"убедительный",
"убежденный",
"убийственный",
"уважительный",
"удивительный",
"ужасающий",
"ужасный",
"умопомрачительный",
"уничтожающий",
"фанатический",
"фанатичный",
"фантастический",
"феноменальный",
"филигранный",
"форменный",
"фундаментальный",
"хороший",
"царский",
"цепенящий",
"черный",
"чертов",
"чертовский",
"чистый",
"чрезвычайный",
"чрезмерный",
"чудовищный",
"широкий",
"широкомасштабный",
"шквальный",
"штормовой",
"шумный",
"щедрый",
"щемящий",
"экстраординарный",
"экстремальный",
"ювелирный",
"ядреный",
"яркий",
"яростный",
"ярый" };

            string[] book = new string[10000];
            for (int i = 0; i < book.Length; i++)
            {
                int check = 0;
                check = rand.Next(0, pril.Length);
                book[i] += pril[check];
                book[i] += " ";
                check = rand.Next(0, sysh.Length);
                book[i] += sysh[check];
                book[i] += "|";
                check = rand.Next(0, b.Length);
                book[i] += b[check];
                book[i] += "|";
                check = rand.Next(0, 18);
                book[i] += z[check];
                book[i] += "|";
                book[i] += rand.Next(868, 2021);
                book[i] += "|";
                book[i] += rand.Next(0, 60);
                book[i] += "|";
                book[i] += rand.Next(100, 250);
                book[i] += "|";
                check = rand.Next(0, 2);
                book[i] += x[check];
                book[i] += "|";
                check = rand.Next(0, 3);
                book[i] += y[check];
                book[i] += "|";
                book[i] += rand.Next(10, 31);
                book[i] += ".";
                book[i] += rand.Next(1, 9);
                book[i] += ".";
                check = rand.Next(2001, 2020);
                book[i] += check;
                book[i] += "|";
                book[i] += rand.Next(10, 31);
                book[i] += ".";
                book[i] += rand.Next(1, 9);
                book[i] += ".";
                book[i] += (check + rand.Next(1, 3));
                book[i] += "|";
                book[i] += rand.Next(0, 6);
            }
            for (int i = 0; i < book.Length; i++)
            {

                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(book[i]);
                }
                Console.WriteLine(book[i]);
            }
        }
    }
}