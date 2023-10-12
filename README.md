# NET01.1 Дизайн классов, наследование, интерфейсы
### Рассматриваемые темы
- основные синтаксические конструкции языка C#
- класс и его элементы
- наследование классов
- методы System.Object и целесообразность их перекрытия
- структуры, перечисления, интерфейсы
- исключительные ситуации

### Описание

При создании сайта тренингов возникла необходимость в описании следующих сущностей. Отдельное занятие тренинга включает набор материалов тренинга. Материал тренинга бывает трёх видов: текстовый материал, видеоматериал, ссылка на сетевой ресурс. Текстовый материал хранит произвольный непустой текст (максимальная длина – 10000 символов). Видеоматериал содержит: URI видеоконтента (непустая строка), URI картинки-заставки, указание на формат видео (значение из фиксированного набора: Unknown, Avi, Mp4, Flv). Ссылка на сетевой ресурс хранит URI контента (непустая строка), указание на тип ссылки (значение из фиксированного набора: Unknown, Html, Image, Audio, Video). Все сущности (включая занятие тренинга) обладают уникальным идентификатором (типа System.Guid) и содержат произвольное текстовое описание (возможно пустое или null, но ограниченное длиной 256 символов).

### Постановка задачи

1.	Создать набор классов, соответствующих сущностям в описании задания (сущности выделены жирным шрифтом) .
2.	В классе, соответствующем занятию тренинга, предусмотреть метод, возвращающий вид занятия. Если занятие содержит хотя бы один видеоматериал, то его вид – VideoLesson, иначе – TextLesson (это элементы перечисления).
3.	Метод ToString() во всех созданных классах должен возвращать текстовое описание сущности (значение из соответствующего свойства).
4.	Создать метод расширения для сущности, генерирующий и присваивающий сущности уникальный идентификатор.
5.	Переопределить метод Equals() сравнения сущностей. Две сущности считаются равными, если совпадают их уникальные идентификаторы.
6.	Занятие тренинга и видеоматериал (и только они) должны содержат версию (массив из восьми байт). Создать интерфейс IVersionable, реализуемый данными сущностями, который содержит методы для чтения и установки версии.
7.	В классе, соответствующем занятию тренинга, реализовать стандартный интерфейс ICloneable . Внимание: клонирование должно быть глубоким, а не поверхностным.