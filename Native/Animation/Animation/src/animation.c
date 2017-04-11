#include "animation.h"

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	Evas_Object *heart;
} appdata_s;

Eina_Bool anim_continue = ECORE_CALLBACK_RENEW;
Ecore_Pos_Map pos_map = ECORE_POS_MAP_LINEAR;

//Показывает идет анимация увеличения или уменьшения
int isIncrease = 1;
int image_width = 100;
int image_height = 100;

static void win_delete_request_cb(void *data, Evas_Object *obj,
		void *event_info) {
	ui_app_exit();
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

//Отрисовка кадров анимации
static Eina_Bool on_next_frame(void *data, double pos) {
	//прогресс анимации от 0 до 1
	double frame = ecore_animator_pos_map(pos, pos_map, 1.2, 15);
	if (isIncrease == 1) {
		//увеличение объекта
		evas_object_resize(data, image_width * (1 + frame * 2), image_height * (1 + frame * 2));
		//Перемещение объекта
		evas_object_move(data, 75 * (1-frame) + 225, 75 * (1 - frame) + 500);
	} else {
		//уменьшение объекта
		evas_object_resize(data, (1 + (1 - frame) * 2) * 100,
				(1 + (1 - frame) * 2) * 100);
		//движение объекта
		evas_object_move(data, 75 * frame + 225, 75 * frame + 500);
	}
	//Проверка конца цикла анимации
	if (frame == 1.0) {
		//Запуск анимации
		ecore_animator_timeline_add(4, on_next_frame, data);
		if (isIncrease == 0) {
			isIncrease = 1;
		} else {
			isIncrease = 0;
		}
	}
	return ECORE_CALLBACK_RENEW;
}

//Получение пути картинки для анимации
static void app_get_resource(const char *res_file_in, char *res_path_out,
		int res_path_max) {
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(res_path_out, res_path_max, "%s%s", res_path, res_file_in);
		free(res_path);
	}
}

//Получение системных настроек
static void get_system_info_int(char* key, int *value)
{
    int ret;
    ret = system_settings_get_value_int(key, &value);
	if (ret != SYSTEM_SETTINGS_ERROR_NONE)
	{
	    // Error handling
	}
	dlog_print(DLOG_INFO, LOG_TAG, "screen size %s : %d", key, value);
	return;
}


static void create_base_gui(appdata_s *ad) {
	/* Window */
	/* Create and initialize elm_win.
	 elm_win is mandatory to manipulate window. */
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

	/* Evas */
	Evas *evas = evas_object_evas_get(ad->win);

	/* Получение пути до картинки */
	char buf[PATH_MAX];
	app_get_resource("heart.png", buf, (int) PATH_MAX);
	/* Добавление картинки на экран */
	ad->heart = elm_image_add(evas);
	elm_image_file_set (ad->heart, buf, NULL);
	//Получение ширины и высоты экрана
	int screen_size_w, screen_size_h;
	get_system_info_int("tizen.org/feature/screen.width",&screen_size_w);
	get_system_info_int("tizen.org/feature/screen.height",&screen_size_h);
//	evas_object_move(ad->heart, 300, 600);
	/*Размещение картинки по центру*/
	evas_object_move(ad->heart, screen_size_w/2, screen_size_h/2);
	evas_object_pass_events_set(ad->heart, EINA_TRUE);
	/*Размер картинки*/
	evas_object_resize(ad->heart, 100, 100);
	evas_object_show(ad->heart);


	/* Анимация */
	ecore_animator_timeline_add(4, on_next_frame, ad->heart);
	/*Частота смены кадров*/
	ecore_animator_frametime_set(1. / 60);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
}

static bool app_create(void *data) {
	/* Hook to take necessary actions before main event loop starts
	 Initialize UI resources and application's data
	 If this function returns true, the main loop of application starts
	 If this function returns false, the application is terminated */
	appdata_s *ad = data;

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

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
