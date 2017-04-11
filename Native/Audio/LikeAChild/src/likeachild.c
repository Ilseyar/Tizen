#include "likeachild.h"
#include <player.h>

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
	player_h player;
} appdata_s;

const char* file_name[] = { "cat.mp3", "dog.mp3", "dug.mp3" };

static void win_delete_request_cb(void *data, Evas_Object *obj,
		void *event_info) {
	ui_app_exit();
}

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

// Возвращает состояние плеера
static player_state_e get_player_state(player_h player) {
	player_state_e state;
	player_get_state(player, &state);
	return state;
}
// Вызывается в конце воспроизведения
static void on_player_completed(player_h* player) {
	if (player)
		player_stop(player);
}

// Создание плеера
static player_h create_player() {
	player_h player;
	player_create(&player);
	//Добавление слушателя конца воспроизведения
	player_set_completed_cb(player, on_player_completed, player);
	return player;
}

// Остановка воспроизведения
static void stop_player(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	if (get_player_state(ad->player) == PLAYER_STATE_PLAYING
			|| get_player_state(ad->player) == PLAYER_STATE_PAUSED) {
		player_stop(ad->player);
	}
}

// Возвращает путь до файлов с аудиозаписями
static inline const char*
get_resource_path(const char *file_path) {
	static char absolute_path[PATH_MAX] = { '\0' };
	static char *res_path_buff = NULL;
	if (res_path_buff == NULL)
		res_path_buff = app_get_resource_path();
	snprintf(absolute_path, PATH_MAX, "%s%s", res_path_buff, file_path);
	return absolute_path;
}

// Загрузка аудиозаписи в плеер
static void prepare_player(appdata_s* ad, int index) {
// Остановка воспроизведения
	stop_player(ad, NULL, NULL);
// Закрытие файла
	player_unprepare(ad->player);
	const char* file = file_name[index];
// Получение пути до файлов с аудиозаписями
	const char *res_path = get_resource_path(file);
// Загрузка файла
	player_set_uri(ad->player, res_path);
// Подготовка к воспроизведению
	int result = player_prepare(ad->player);
	dlog_print(DLOG_INFO, "tag", "File load : %d", result);
}

static void my_box_pack(Evas_Object *box, Evas_Object *child, double h_weight,
		double v_weight, double h_align, double v_align) {
	/* Создание фрейма внутри которого можно задавать отступы между дочерними элементами*/
	Evas_Object *frame = elm_frame_add(box);
	/* Использование стиля pad_medium для размера отступа. Доступны также "pad_small",
	 * "pad_medium", "pad_large" and "pad_huge" и "default" */
	elm_object_style_set(frame, "pad_medium");
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

//Воспроизведение звуков кошки
static void start_player_cat(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	// Загрузка аудиофайла в плеер
	prepare_player(ad, 0);
	if (get_player_state(ad->player) != PLAYER_STATE_PLAYING) {
		player_start(ad->player);
	}
}

//Воспроизведение звуков собаки
static void start_player_dog(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	// Загрузка аудиофайла в плеер
	prepare_player(ad, 1);
	if (get_player_state(ad->player) != PLAYER_STATE_PLAYING) {
		player_start(ad->player);
	}
}

//Воспроизведение звуков утки
static void start_player_dug(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	// Загрузка аудиофайла в плеер
	prepare_player(ad, 2);
	if (get_player_state(ad->player) != PLAYER_STATE_PLAYING) {
		player_start(ad->player);
	}
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
			win_delete_request_cb,
			NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb,
			ad);

	/* Conformant */
	/* Create and initialize elm_conformant.
	 elm_conformant is mandatory for base gui to have proper size
	 when indicator or virtual keypad is visible. */
	ad->conform = elm_conformant_add(ad->win);
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);

	{
		Evas_Object * box, *btn_cat, *btn_dog, *btn_dug;
		/* Элемент box для расположения элементов вертикально */
		box = elm_box_add(ad->win);
		evas_object_size_hint_weight_set(box, EVAS_HINT_EXPAND,
		EVAS_HINT_EXPAND);
		elm_object_content_set(ad->conform, box);
		evas_object_show(box);
		{
			/* Label*/
			ad->label = elm_label_add(ad->win);
			elm_object_text_set(ad->label, "<align=center>Animal Sounds</>");
			/* Растянуть горизонтально, расположить по центру вертикально */
			my_box_pack(box, ad->label, 1.0, 0.0, -1.0, 0.0);

			/* Cat Button */
			btn_cat = elm_button_add(ad->win);
			elm_object_text_set(btn_cat, "Cat");
			evas_object_smart_callback_add(btn_cat, "clicked", start_player_cat,
					ad);
			my_box_pack(box, btn_cat, 1.0, 0.0, -1.0, 0.0);

			btn_dog = elm_button_add(ad->win);
			elm_object_text_set(btn_dog, "Dog");
			evas_object_smart_callback_add(btn_dog, "clicked", start_player_dog,
					ad);
			my_box_pack(box, btn_dog, 1.0, 0.0, -1.0, 0.0);

			btn_dug = elm_button_add(ad->win);
			elm_object_text_set(btn_dug, "Dug");
			evas_object_smart_callback_add(btn_dug, "clicked", start_player_dug,
					ad);
			my_box_pack(box, btn_dug, 1.0, 0.0, -1.0, 0.0);
		}
	}

	/* Show window after base gui is set up */
	evas_object_show(ad->win);

	ad->player = create_player();

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
