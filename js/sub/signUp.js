// 다음 우편번호 api
function sample6_execDaumPostcode() {
	var width = 500; //팝업의 너비
	var height = 600; //팝업의 높이

	new daum.Postcode({
		width: width, //생성자에 크기 값을 명시적으로 지정해야 합니다.
		height: height,

		oncomplete: function (data) {
			// 팝업에서 검색결과 항목을 클릭했을때 실행할 코드를 작성하는 부분.

			// 각 주소의 노출 규칙에 따라 주소를 조합한다.
			// 내려오는 변수가 값이 없는 경우엔 공백('')값을 가지므로, 이를 참고하여 분기 한다.
			var addr = ''; // 주소 변수
			var extraAddr = ''; // 참고항목 변수

			//사용자가 선택한 주소 타입에 따라 해당 주소 값을 가져온다.
			if (data.userSelectedType === 'R') {
				// 사용자가 도로명 주소를 선택했을 경우
				addr = data.roadAddress;
			} else {
				// 사용자가 지번 주소를 선택했을 경우(J)
				addr = data.jibunAddress;
			}

			// 사용자가 선택한 주소가 도로명 타입일때 참고항목을 조합한다.
			if (data.userSelectedType === 'R') {
				// 법정동명이 있을 경우 추가한다. (법정리는 제외)
				// 법정동의 경우 마지막 문자가 "동/로/가"로 끝난다.
				if (data.bname !== '' && /[동|로|가]$/g.test(data.bname)) {
					extraAddr += data.bname;
				}
				// 건물명이 있고, 공동주택일 경우 추가한다.
				if (data.buildingName !== '' && data.apartment === 'Y') {
					extraAddr += extraAddr !== '' ? ', ' + data.buildingName : data.buildingName;
				}
				// 표시할 참고항목이 있을 경우, 괄호까지 추가한 최종 문자열을 만든다.
				if (extraAddr !== '') {
					extraAddr = ' (' + extraAddr + ')';
				}
				// 조합된 참고항목을 해당 필드에 넣는다.
				document.getElementById('sample6_extraAddress').value = extraAddr;
			} else {
				document.getElementById('sample6_extraAddress').value = '';
			}

			// 우편번호와 주소 정보를 해당 필드에 넣는다.
			document.getElementById('sample6_postcode').value = data.zonecode;
			document.getElementById('sample6_address').value = addr;
			// 커서를 상세주소 필드로 이동한다.
			document.getElementById('sample6_detailAddress').focus();
		},
		theme: {
			searchBgColor: '#1B2539', //검색창 배경색
			queryTextColor: '#FFFFFF', //검색창 글자색
		},
	}).open({
		popupTitle: '우편번호 검색 팝업',
		popupKey: 'popup1',
		left: window.screen.width / 2 - width / 2,
		top: window.screen.height / 2 - height / 2,
	});
}

//password strength 표기
const password = document.querySelector('#password');
const strengthBar = document.querySelector('#meter');
var display = document.querySelector('.textbox');

password.addEventListener('keyup', function () {
	checkPassword(password.value);
});

function checkPassword(password) {
	let strength = 0;
	const regexes = [/[a-z]+/, /[A-Z]+/, /[0-9]+/, /[$@#&!]+/];

	regexes.forEach((regex, index) => {
		strength += password.match(regex) ? 1 : 0;
	});

	strengthBar.value = strength;

	switch (strength) {
		case 1:
			strengthBar.style.setProperty('--c', 'red');
			break;
		case 2:
		case 3:
			strengthBar.style.setProperty('--c', 'orange');
			break;
		case 4:
			strengthBar.style.setProperty('--c', 'green');
			break;
	}

	if (password.length < 6) {
		display.textContent = 'minimum number of characters is 6';
		strengthBar.style.setProperty('--c', 'red');
	} else if (password.length > 15) {
		display.textContent = 'maximum number of characters is 15';
		strengthBar.style.setProperty('--c', 'red');
	} else {
		display.textContent = '';
	}
}

const textareaCount = document.querySelector('.textareaCount');
const introduceForm = document.querySelector('.introduceForm');

//introduce textarea 글자수 카운팅 및 글자수 제한
introduceForm.addEventListener('keyup', function () {
	let counter = introduceForm.value;
	textareaCount.innerText = '(' + counter.length + ' / 200)';

	if (counter.length > 200) {
		alert('최대 200자까지 입력 가능합니다.');
		introduceForm.value = counter.substring(0, 200);
		textareaCount.innerText = '(200 / 200)';
	}
});

const form1 = document.querySelector('#signUp');
const form2 = document.querySelector('#signUp2');
const form3 = document.querySelector('#signUp3');
const btnSubmit = document.querySelector('input[type=submit]');
const errRed = '#d80000';

//form submit button
btnSubmit.addEventListener('click', (e) => {
	if (!isId('userid', 6, 12)) {
		e.preventDefault();
		form1.querySelector('.idErr').style.color = errRed;
	}
	if (!isNickName('nickname', 1, 12)) {
		e.preventDefault();
		form1.querySelector('.nickErr').style.color = errRed;
	}
	if (!isPassWord('password', 'passwordCheck', 10, 20)) {
		e.preventDefault();
		form1.querySelector('.pwdErr').style.color = errRed;
	}
	if (!isPassWordCheck('password', 'passwordCheck', 10, 20)) {
		e.preventDefault();
		form1.querySelector('.pwdErr2').style.color = errRed;
	}
	if (!isEmail('email', 4)) e.preventDefault();
	if (!isEmailAdd('emailAddress', 6)) e.preventDefault();
	if (!isPostNum('postcode', 4)) e.preventDefault();
	if (!isDetailAdd('detailAddress', 6)) e.preventDefault();
});

//id 인증 항목
function isId(name, minLen, maxLen) {
	const idInput = form1.querySelector(`[name=${name}`);
	const idValue = idInput.value.trim();

	//영문(소문자만가능), 숫자를 포함한 6~12자 조합
	const idRegex = /^[a-z0-9]{6,12}$/;

	if (idValue.length < minLen || idValue.length > maxLen || !idRegex.test(idValue)) {
		if (idValue.length < minLen) {
			alert(`아이디는 ${minLen}글자 이상 입력하세요.`);
		} else if (idValue.length > maxLen) {
			alert(`아이디는 ${maxLen}글자 이하 입력하세요.`);
		} else {
			alert(`아이디는 영문 소문자와 숫자를 포함한 6~12자로 입력해주세요.`);
		}
		return false;
	} else {
		return true;
	}
}

//nickname 인증
function isNickName(name, minLen, maxLen) {
	const nickInput = form1.querySelector(`[name=${name}`);
	const nickValue = nickInput.value.trim();

	//한글,영문(대소문자가능), 숫자,공백을 포함한 1~12자 조합으로 입력해주세요.
	const nickRegex = /^[a-zA-Zㄱ-힣0-9\s]{1,12}$/;

	if (!nickRegex.test(nickInput)) {
		alert(`닉네임은 한글, 영문(대소문자 가능), 숫자, 공백을 포함한 1~12자로 입력해주세요.`);
		return false;
	} else if (idValue.length < minLen) {
		alert(`닉네임은 ${minLen}글자 이상 입력하세요.`);
		return false;
	} else if (idValue.length > maxLen) {
		alert(`닉네임은 ${maxLen}글자 이하 입력하세요.`);
		return false;
	} else {
		return true;
	}
}

//password 인증
function isPassWord(password, passwordCheck, minLen, maxLen) {
	const password_val = form1.querySelector(`[name=${password}`).value.trim();
	const passwordCheck_val = form1.querySelector(`[name=${passwordCheck}`).value.trim();

	//영문(대문자 1개이상 필수),숫자,특수문자(~!@#$%^&*)를 포함한 10~20자 조합으로 입력해 주세요.
	const passWordRegex = /^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[!@#$%^&*]).{10,20}$/;

	if (!passWordRegex.test(password_val)) {
		alert(`비밀번호는 한글, 영문(대문자 1개이상 필수), 숫자, 공백을 포함한 1~12자로 입력해주세요.`);
		return false;
	} else if (password_val.length < minLen) {
		alert(`비밀번호는 ${minLen}글자 이상 입력하세요.`);
		return false;
	} else if (password_val.length > maxLen) {
		alert(`비밀번호는 ${maxLen}글자 이하 입력하세요.`);
		return false;
	} else {
		return true;
	}
}

//password 중복확인 인증
function isPassWordCheck(password, passwordCheck) {
	const password_val = form1.querySelector(`[name=${password}`).value.trim();
	const passwordCheck_val = form1.querySelector(`[name=${passwordCheck}`).value.trim();

	if (password_val !== passwordCheck_val) {
		alert('비밀번호 항목 2개가 동일하지 않습니다.');
		return false;
	} else {
		return true;
	}
}

// email 아이디 인증
const emailAddressSelect = form1.querySelector('#emailAddressSelect');
const emailAddress = form1.querySelector('#emailAddress');

//조건 - 입력한 문자가 4글자 이상
function isEmail(name, len) {
	const email = form1.querySelector(`[name=${name}]`).value;
	if (email.length < len) {
		alert(`이메일 아이디는 ${len}글자 이상 입력하세요.`);
		return false;
	} else {
		return true;
	}
}

// email 아이디 주소 인증
//조건 - 입력한 문자가 6글자 이상
function isEmailAdd(name, len) {
	const emailAdd = form1.querySelector(`[name=${name}]`).value;
	if (emailAdd.length < len) {
		alert(`이메일 주소는 ${len}글자 이상 입력하세요.`);
		return false;
	} else {
		return true;
	}
}

// password 보이기 숨기기 기능
const pwdIcon = form1.querySelectorAll('.fa-eye')[0];
const pwdInput = form1.querySelector('#password');

let click = 0;
pwdIcon.addEventListener('click', function () {
	click++;
	if (click % 2 === 0) {
		pwdIcon.style.color = '#969696';
		pwdInput.type = 'password';
	} else if (click % 2 !== 0) {
		pwdIcon.style.color = '#1b2539';
		pwdInput.type = 'text';
	}
});

// password 중복확인 보이기 숨기기 기능
const pwdIconCheck = form1.querySelectorAll('.fa-eye')[1];
const pwdInputCheck = form1.querySelector('#passwordCheck');

let click2 = 0;
pwdIconCheck.addEventListener('click', function () {
	click2++;
	if (click2 % 2 === 0) {
		pwdIconCheck.style.color = '#969696';
		pwdInputCheck.type = 'password';
	} else if (click2 % 2 !== 0) {
		pwdIconCheck.style.color = '#1b2539';
		pwdInputCheck.type = 'text';
	}
});

//email_address select할 시 input값 자동 입력
emailAddressSelect.addEventListener('click', function () {
	if (emailAddressSelect.value === '') {
		form1.querySelector('#emailAddress').disabled = false;
		form1.querySelector('#emailAddress').value = emailAddressSelect.value;
	} else if (emailAddressSelect.value !== '') {
		form1.querySelector('#emailAddress').value = emailAddressSelect.value;
		form1.querySelector('#emailAddress').disabled = true;
		form1.querySelector('#emailAddress').style.background = '#f4f5f6';
	} else return;
});

// postnumber 인증
const postcodeInput = document.querySelector('#sample6_postcode');

//조건 - 입력한 문자가 6글자 이상
function isPostNum(name, len) {
	const postNum = form2.querySelector(`[name=${name}]`).value;

	const postRegex = /^\d{5}$/; // 5자리 숫자

	if (!postRegex.test(postNum)) {
		alert('올바른 우편번호를 입력해주세요.');
		return false;
	} else {
		return true;
	}
}

// address 상세주소 인증
const detailAddressInput = document.querySelector('#sample6_detailAddress');

//조건 - 입력한 문자가 6글자 이상
function isDetailAdd(name, len) {
	const detailAdd = form2.querySelector(`[name=${name}]`).value;

	if (detailAdd.length < 6) {
		alert('상세주소는 최소 6글자 이상 입력해주세요.');
		return false;
	} else {
		return true;
	}
}

// 폼 초기화 버튼
const resetButton = document.querySelector('.resetBtn');

resetButton.addEventListener('click', function () {
	form1.reset();
	form2.reset();
	form3.reset();
});
