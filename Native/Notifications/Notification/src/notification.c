#include <tizen.h>
#include "notification.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;

} appdata_s;

static void win_delete_request_cb(void *data, Evas_Object *obj,
		void *event_info) {
	ui_app_exit();
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

void my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight,
		double v_weight, double h_align, double v_align) {
	/* Создание фрейма внутри которого можно задавать отступы между дочерними элементами*/
	Evas_Object *frame = elm_frame_add(box);
	/* Использование стиля pad_medium для размера отступа. Доступны также "pad_small",
				 * "pad_medium", "pad_large" and "pad_huge" и "default" */
	elm_object_style_set(frame, "pad_small");
	/* задание веса и выравнивание фрейма */
	evas_object_size_hint_weight_set(frame, h_weight, v_weight);
	evas_object_size_hint_align_set(frame, h_align, v_align);
	{
		/* Чтобы дочерние элементы могли растягиваться внутри фрейма */
		evas_object_size_hint_weight_set(child, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		/* Выравнивание дочерних элементов */
		evas_object_size_hint_align_set(child, EVAS_HINT_FILL, EVAS_HINT_FILL);
		/* Добавление дочерних элементов в фрейм*/
		evas_object_show(child);
		elm_object_content_set(frame, child);
	}
	/* Добавление фрейма в родительский элемент box */
	elm_box_pack_end(box, frame);
	/* Отобразить фрейм*/
	evas_object_show(frame);
}

static Evas_Object* create_notify_top_timeout(Evas_Object *parent) {
	Evas_Object *notify;
	Evas_Object *box;
	Evas_Object *label;

	/*создание уведомления*/
	notify = elm_notify_add(parent);
	elm_notify_align_set(notify, 0.5, 0.0);
	/*Установка таймера на автоматическое скрытие уведомления*/
	elm_notify_timeout_set(notify, 3.0);

	box = elm_box_add(notify);
	evas_object_show(box);

	/*Текст для уведомления*/
	label = elm_label_add(box);
	evas_object_size_hint_min_set(label, ELM_SCALE_SIZE(480), 0);
	elm_label_line_wrap_set(label, ELM_WRAP_WORD);
	elm_object_text_set(label, "<font align=center>Уведомление, которое исчезнет через 3 секунды</font>");
	elm_box_pack_end(box, label);
	evas_object_show(label);

	elm_object_content_set(notify, box);
	return notify;
}

static void btn_click_cb(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *notify = data;
	evas_object_show(notify);
}

static void btn_hide_notify_cb(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *notify = data;
	evas_object_hide(notify);
}

static Evas_Object* create_notify_top_manual(Evas_Object *parent){
	Evas_Object *notify;
	Evas_Object *box;
	Evas_Object *label;
	Evas_Object *btn;

	notify = elm_notify_add(parent);
	elm_notify_align_set(notify, 0.5, 0.0);
	elm_notify_timeout_set(notify, 3.0);
	elm_notify_allow_events_set(notify, EINA_TRUE);

	box = elm_box_add(notify);
	evas_object_show(box);

	/*Текст для уведомления*/
	label = elm_label_add(box);
	evas_object_size_hint_min_set(label, ELM_SCALE_SIZE(480), 0);
	elm_label_line_wrap_set(label, ELM_WRAP_WORD);
	elm_object_text_set(label, "<font align=center>Нажмите на кнопку, чтобы уведомление исчезло</font>");
	elm_box_pack_end(box, label);
	evas_object_show(label);

	btn = elm_button_add(box);
	elm_object_text_set(btn, "OK");
	evas_object_size_hint_min_set(btn, ELM_SCALE_SIZE(80), ELM_SCALE_SIZE(58));
	elm_box_pack_end(box, btn);
	evas_object_show(btn);
	evas_object_smart_callback_add(btn, "clicked", btn_hide_notify_cb, notify);

	elm_object_content_set(notify, box);

	return notify;
}

static void btn_click_cb2(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *notify = data;
	evas_object_show(notify);
}


static Evas_Object* create_notify_top_block(Evas_Object *parent){
	Evas_Object *notify;
	Evas_Object *box;
	Evas_Object *label;

	notify = elm_notify_add(parent);
	elm_notify_align_set(notify, 0.5, 0.0);
	elm_notify_timeout_set(notify, 3.0);
	elm_notify_allow_events_set(notify, EINA_FALSE);

	box = elm_box_add(notify);
	evas_object_show(box);

	/*Текст для уведомления*/
	label = elm_label_add(box);
	evas_object_size_hint_min_set(label, ELM_SCALE_SIZE(480), 0);
	elm_label_line_wrap_set(label, ELM_WRAP_WORD);
	elm_object_text_set(label, "<font align=center>Нажмите на кнопку, чтобы уведомление исчезло</font>");
	elm_box_pack_end(box, label);
	evas_object_show(label);

	elm_object_content_set(notify, box);

	return notify;
}

static void btn_click_cb3(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *notify = data;
	evas_object_show(notify);
}

static Evas_Object* create_notify_bottom(Evas_Object *parent){
	Evas_Object *notify;
	Evas_Object *box;
	Evas_Object *label;

	notify = elm_notify_add(parent);
	elm_notify_align_set(notify, 0.5, 1.0);
	elm_notify_timeout_set(notify, 3.0);
	elm_notify_allow_events_set(notify, EINA_FALSE);

	box = elm_box_add(notify);
	evas_object_show(box);

	/*Текст для уведомления*/
	label = elm_label_add(box);
	evas_object_size_hint_min_set(label, ELM_SCALE_SIZE(480), 0);
	elm_label_line_wrap_set(label, ELM_WRAP_WORD);
	elm_object_text_set(label, "<font align=center>Уведомление появится снизу</font>");
	elm_box_pack_end(box, label);
	evas_object_show(label);

	elm_object_content_set(notify, box);

	return notify;
}

static void btn_click_cb4(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *notify = data;
	evas_object_show(notify);
}

static void create_base_gui(appdata_s *ad) {
	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win,
				(const int *) (&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request",
			win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb,
			ad);

	/* Conformant */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,
			EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	{
		Evas_Object *box = elm_box_add(ad->win);
		evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		elm_object_content_set(ad->conform, box);
		evas_object_show(box);

		{
			Evas_Object* notify = create_notify_top_timeout(box);

			/*Button-1*/
			Evas_Object *btn1 = elm_button_add(ad->conform);
			elm_object_text_set(btn1, "Показать исчезающее уведомление");
			evas_object_smart_callback_add(btn1, "clicked", btn_click_cb, notify);
			my_box_pack(box, btn1, 1.0, 1.0, -1.0, -1.0);

			Evas_Object* notify1 = create_notify_top_manual(box);

			/*Button-2*/
			Evas_Object *btn2 = elm_button_add(ad->conform);
			elm_object_text_set(btn2, "Показать уведомление с кнопкой");
			evas_object_smart_callback_add(btn2, "clicked", btn_click_cb2, notify1);
			my_box_pack(box, btn2, 1.0, 1.0, -1.0, -1.0);

			Evas_Object* notify3 = create_notify_top_manual(box);

			/*Button-3*/
			Evas_Object *btn3 = elm_button_add(ad->conform);
			elm_object_text_set(btn3, "Показать блокирующее уведомление");
			evas_object_smart_callback_add(btn3, "clicked", btn_click_cb3, notify3);
			my_box_pack(box, btn3, 1.0, 1.0, -1.0, -1.0);

			Evas_Object* notify4 = create_notify_bottom(box);

			/*Button-4*/
			Evas_Object *btn4 = elm_button_add(ad->conform);
			elm_object_text_set(btn4, "Показать уведомление внизу");
			evas_object_smart_callback_add(btn4, "clicked", btn_click_cb4, notify4);
			my_box_pack(box, btn4, 1.0, 1.0, -1.0, -1.0);
		}
	}

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool app_create(void *data) {
	/* Hook to take necessary actions before main event loop starts
	 Initialize UI resources and application's data
	 If this function returns true, the main loop of application starts
	 If this function returns false, the application is terminated */
	appdata_s *ad = data;
	/*Для форматирования вывода уведомления*/
	elm_app_base_scale_set(1.8);
	create_base_gui(ad);

	return true;
}

static void app_control(app_control_h app_control, void *data) {
	/* Handle the launch request. */
}

static void app_pause(void *data) {
	/* Take necessary actions when application becomes invisible. */
}

static void app_resume(void *data) {
	/* Take necessary actions when application becomes visible. */
}

static void app_terminate(void *data) {
	/* Release all resources. */
}

static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE,
			&locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_BATTERY*/
}

static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char *argv[]) {
	appdata_s ad = { 0, };
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = { 0, };
	app_event_handler_h handlers[5] = { NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
			APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY],
			APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
			APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
			APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
			APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
