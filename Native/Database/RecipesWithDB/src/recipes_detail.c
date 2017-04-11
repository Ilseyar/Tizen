#include "recipes.h"

static Evas_Object *label_desc;

//Слушатель на успешное считываение рецепта из бд
static int db_read_cb(void *counter, int argc, char **argv, char **azColName){
	char description[255];
	strcpy(description, argv[1]);
	elm_object_text_set(label_desc, description);
}

//Чтение из бд описания рецепта
static int read_recept(int key){
	char sql[255];
	sprintf(sql, 255, "select * from Recipes where key = \'%s\'", key);
	int counter = 0;
	char *err_msg;

	int ret = sqlite3_exec(db, sql, db_read_cb, &counter, &err_msg);
	return ret;
}

//Создание элемента label для вывода текста на экран
static Evas_Object*
create_label_view(Evas_Object* parent, char* text) {
	Evas_Object *label, *box;

	box = elm_box_add(parent);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL,
			EVAS_HINT_FILL);

	label = elm_label_add(box);
	label_desc = label;
	elm_object_text_set(label, text);
	evas_object_show(label);
	my_box_pack(box, label, 1.0, 1.0, -1.0, -1.0);

	return box;
}

void recipes_detail_cb(void *data, Evas_Object *obj, void *event_info) {
	int key = (int) data;
	Evas_Object *scroller, *layout;

	//Добавление прокрутки на экран
	scroller = elm_scroller_add(nf);
	layout = create_label_view(scroller, "");
	elm_object_content_set(scroller, layout);

	//Задание заголовка страницы
	elm_naviframe_item_push(nf, "Описание рецепта", NULL, NULL, scroller, NULL);
	//Получение описание из бд по id
	read_recept(key);
}
