const host = "http://localhost:5202";
const endpoint = "/api/teacher/getTeacherFormData/";
const updateApi = "/api/teacher/updateCourse";

const jwt = localStorage.getItem("JWT");

const config = {
  headers: {
    Authorization: "Bearer " + jwt,
  },
};

const courseFormContainer = document.querySelector(".course-form-container");

function renderForm(course) {
  courseFormContainer.innerHTML = `
    <h1 class="text-center">刊登課程</h1>
    <form id="teacher-application-form" enctype="multipart/form-data">
        <div class="form-group">
          <input
            type="text"
            class="form-control item"
            id="course-name"
            value="${course.courseName}"
            placeholder="課程名稱"
          />
        </div>
        <div class="form-group">
          <input
            type="text"
            class="form-control item"
            id="course-category"
            value="${course.courseCategory}"
            placeholder="課程分類"
          />
        </div>
        <div class="form-group">
          <input
            type="text"
            class="form-control item"
            id="course-way"
            value="${course.courseWay}"
            placeholder="授課方式"
          />
        </div>
        <div class="form-group">
          <input
            type="text"
            class="form-control item"
            id="course-language"
            value="${course.courseLanguage}"
            placeholder="授課語言"
          />
        </div>
        <div class="form-group">
          <input
            type="text"
            class="form-control item"
            id="course-location"
            value="${course.courseLocation}"
            placeholder="授課地點"
          />
        </div>
        <div class="form-group">
          <textarea
            type="text"
            class="form-control item"
            id="course-intro"
            placeholder="課程詳細介紹"
          >${course.courseIntro}</textarea>
        </div>
        <div class="form-group">
          <textarea
            type="text"
            class="form-control item"
            id="course-reminder"
            placeholder="課程注意事項"
          >${course.courseReminder}</textarea>
        </div>
        <div class="form-group">
          <label for="course-image" class="form-label">課程宣傳照</label>
          <input
            type="file"
            class="form-control item"
            id="course-image"
            accept=",.png,.jpg,.jpeg"
          />
        </div>
        <div class="course-time-container">
          <label for="course-time" class="form-label">課程時段</label>
          <div class="row form-row">
            <div class="col-4">
              <label for="startTime">開始時間</label>
              <input
                type="datetime-local"
                class="form-control"
                id="startTime"
                name="startTime"
              />
            </div>
            <div class="col-4">
              <label for="endTime">結束時間</label>
              <input
                type="datetime-local"
                class="form-control"
                id="endTime"
                name="endTime"
              />
            </div>
            <div class="col-2">
              <label for="price">費用</label>
              <input
                type="number"
                class="form-control"
                id="price"
                name="price"
              />
            </div>
            <div
              class="col-2 d-flex text-center align-items-center justify-content-center"
            >
              <button type="button" class="btn btn-primary" id="add-input">
                新增
              </button>
            </div>
          </div>
        </div>
        <div class="form-group text-center btn-container">
          <button type="submit" class="btn btn-block publish">刊登課程</button>
        </div>
      </form>
  `;
}

function generateTimeBlock() {
  $("#add-input").click(function () {
    const newTimeblock = $("<div>").addClass("row form-row");

    newTimeblock.html(`
      <div class="col-4">
        <label for="startTime">開始時間</label>
        <input 
          type="datetime-local" 
          class="form-control" 
          name="startTime"
          id="startTime"
        />
      </div>
      <div class="col-4">
        <label for="endTime">結束時間</label>
        <input 
          type="datetime-local" 
          class="form-control" 
          name="endTime" 
          id="endTime"
        />
      </div>
      <div class="col-2">
        <label for="price">費用</label>
        <input
          type="number"
          class="form-control"
          id="price"
          name="price"
        />
      </div>
      <div class="col-2 d-flex text-center align-items-center justify-content-center">
        <button type="button" class="btn btn-danger remove-input">移除</button>
      </div>
    `);

    $(".course-time-container").append(newTimeblock);
  });

  $(".course-time-container").on("click", ".remove-input", function () {
    $(this).closest(".form-row").remove();
  });
}

function submitEditForm() {
  $("#teacher-application-form").submit((e) => {
    e.preventDefault();

    let formData = new FormData();
    formData.append("courseName", $("#course-name").val());
    formData.append("courseCategory", $("#course-category").val());
    formData.append("courseLocation", $("#course-location").val());
    formData.append("courseWay", $("#course-way").val());
    formData.append("courseLanguage", $("#course-language").val());
    formData.append("courseIntro", $("#course-intro").val());
    formData.append("courseReminder", $("#course-reminder").val());
    formData.append("courseImageFile", $("#course-image")[0].files[0]);

    let startTimeArr = [];
    if (startTime.length) {
      for (i = 0; i < startTime.length; i++) {
        startTimeArr.push(startTime[i].value);
      }
      for (var i = 0; i < startTime.length; i++) {
        formData.append("courses[" + i + "].startTime", startTimeArr[i]);
      }
    } else if (startTime === null) {
      formData.append("courses[0].startTime", null);
    } else {
      formData.append("courses[0].startTime", startTime.value);
    }

    let endTimeArr = [];
    if (endTime.length) {
      for (i = 0; i < endTime.length; i++) {
        endTimeArr.push(endTime[i].value);
      }
      for (var i = 0; i < endTime.length; i++) {
        formData.append("courses[" + i + "].endTime", endTimeArr[i]);
      }
    } else if (startTime === null) {
      formData.append("courses[0].endTime", null);
    } else {
      formData.append("courses[0].endTime", endTime.value);
    }

    let priceArr = [];
    if (price.length) {
      for (i = 0; i < price.length; i++) {
        priceArr.push(price[i].value);
      }
      for (var i = 0; i < price.length; i++) {
        formData.append("courses[" + i + "].price", priceArr[i]);
      }
    } else if (startTime === null) {
      formData.append("courses[0].price", null);
    } else {
      formData.append("courses[0].price", price.value);
    }

    console.log(...formData);

    axios
      .put(host + updateApi, formData, config)
      .then((response) => {
        if (response.status === 200) {
          alert("刊登成功！");
          location.reload();
        } else {
          return new Error("刊登失敗！");
        }
      })
      .catch((err) => console.log(err));
  });
}

/***************************
 * Render form
 ***************************/
axios
  .get(host + endpoint, config)
  .then((response) => {
    return response.data;
  })
  .then((course) => {
    renderForm(course);
    generateTimeBlock();
    submitEditForm();
  })
  .catch((err) => console.log(err));
