#include "recipes.h"

static Evas_Object*
create_label_view(Evas_Object* parent, char* text) {
	Evas_Object *label, *box;

	box = elm_box_add(parent);
	evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(box, EVAS_HINT_FILL,
			EVAS_HINT_FILL);

	/*icon_reorder style*/
	label = elm_label_add(box);
	elm_object_text_set(label, text);
	evas_object_show(label);
	my_box_pack(box, label, 1.0, 1.0, -1.0, -1.0);

	return box;
}

void recipes_detail_cb(void *data, Evas_Object *obj, void *event_info) {
	const char *items[] = {
				"Рецепт борща",
				"Рецепт оливье",
				"Рецепт котлет",
				"Рецепт плова",
				"Рецепт макарон по-флотски",
				"Рецепт ухи",
				"Рецепт торта Наполеон",
				"Рецепт ватрушки",
				"Рецепт лапши",
				"Рецепт яичницы"
		};
	Evas_Object *scroller, *layout;

	/*Добавление прокрутки на экран*/
	scroller = elm_scroller_add(nf);
	layout = create_label_view(scroller, items[(int)data]);
	elm_object_content_set(scroller, layout);

	elm_naviframe_item_push(nf, "Описание рецепта", NULL, NULL, scroller, NULL);
}
