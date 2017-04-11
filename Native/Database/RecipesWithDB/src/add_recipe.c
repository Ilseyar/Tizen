#include "recipes.h"

typedef struct entrydata{
	Evas_Object *entry_name;
	Evas_Object *entry_description;
} entrydata_s;

//Добавление рецепта в бд
static int insert_recipe(const char* name, const char* description){
	char sql[255];
	char *err_msg;
	//Создание текста sql запроса для вставки данных
	snprintf(sql, 256, "INSERT INTO Recipes VALUES(NULL, \'%s\', \'%s\');", name, description);
	//Выполнение sql запроса
	int ret = sqlite3_exec(db, sql, NULL, 0, &err_msg);
	return ret;
}

//Обработка нажатия на кнопку добавления рецепта
static void btn_clicked_cb(void *data, Evas_Object *obj, void *event_info) {
	entrydata_s* ed = data;
	//Получение введенного названия
	const char *name = elm_entry_entry_get(ed->entry_name);
	//Получение описания рецепта
	const char *description = elm_entry_entry_get(ed->entry_description);
	insert_recipe(name, description);
}

/*Располагает элементы в таблице*/
static void my_table_pack(Evas_Object *table, Evas_Object *child, int x, int y,
		int w, int h) {
	evas_object_size_hint_align_set(child, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(child, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_table_pack(table, child, x, y, w, h);
	evas_object_show(child);
}

void add_recipe_cb(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *box = elm_box_add(nf);
	Evas_Object *entry_name;
	Evas_Object *entry_description;

	/* Table */
	Evas_Object *table = elm_table_add(box);
	elm_table_homogeneous_set(table, EINA_TRUE);
	elm_table_padding_set(table, 20 * elm_config_scale_get(),
			20 * elm_config_scale_get());
	evas_object_size_hint_weight_set(table, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(table, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_pack_end(box, table);
	evas_object_show(table);

	entry_name = elm_entry_add(box);
	entry_description = elm_entry_add(box);
	elm_entry_single_line_set(entry_name, EINA_TRUE);
	elm_object_part_text_set(entry_name, "elm.guide", "Ведите название");
	elm_entry_single_line_set(entry_description, EINA_FALSE);
	elm_object_part_text_set(entry_description, "elm.guide", "Ведите описание");

	/*Создание фона всего экрана*/
	Evas_Object* bg_main = elm_bg_add(box);
	elm_bg_color_set(bg_main, 255, 255, 255);
	my_table_pack(table, bg_main, 0, 0, 5, 10);

	/*Создание фона для поля ввода названия*/
	Evas_Object *bg = elm_bg_add(box);
	elm_bg_color_set(bg, 170, 220, 255);
	my_table_pack(table, bg, 0, 0, 5, 2);
	my_table_pack(table, entry_name, 0, 0, 5, 2);

	/*Создание фона для поля ввода описания*/
	Evas_Object *bg1 = elm_bg_add(box);
	elm_bg_color_set(bg1, 170, 220, 255);
	my_table_pack(table, bg1, 0, 2, 5, 6);
	my_table_pack(table, entry_description, 0, 2, 5, 1);

	/*Создание объекта структуры рецепта*/
	entrydata_s *ed = malloc(sizeof(entrydata_s));
	ed->entry_name = entry_name;
	ed->entry_description = entry_description;

	/*Создание кнопки добавить*/
	Evas_Object *btn = elm_button_add(box);
	elm_object_text_set(btn, "Добавить");
	evas_object_smart_callback_add(btn, "clicked", btn_clicked_cb, (void*) ed);
	my_table_pack(table, btn, 0, 8, 5, 1);

	elm_naviframe_item_push(nf, "Добавить рецепт", NULL, NULL, box, NULL);
}
