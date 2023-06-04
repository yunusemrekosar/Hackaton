// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const main = document.querySelector('header');
const reg = document.querySelector('.registerCon');
const logging = document.querySelector('.loginCon');
const form = document.querySelector('.formCon');

const registerOpen = () => {
	main.classList.add('blur');
	reg.classList.remove('hidden');
	if (logging.innerHTML != '') {
		logging.innerHTML = '';
	}
	if (form.innerHTML != '') {
		form.innerHTML = '';
	}
	reg.innerHTML = `
        <div
				class="d-grid bg-transparent justify-content-center align-items-center vh-100 vw-100 z-5  gap-3 ">
				<div class="col d-flex justify-content-center flex-column gap-5 h-50 w-100 p-5  bg-dark text-white rounded-4" style='z-index:10;
				box-shadow: -27px 34px 52px -15px rgba(0,0,0,0.2);
				'>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">E-MAİL</h3>
						<input
							type="email"
							id="email" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">ŞİFRE</h3>
						<input
							type="password"
							id="password" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">ŞİFRE DOĞRULAMA</h3>
						<input
							type="password"
							id="passwordRepeat" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<a
							class="btn btn-light close"
							onclick="registerClose()"
							>GERİ</a
						>
						<input
							class="btn btn-light"
							type="button"
							value="KAYIT OL" />
					</div>
				</div>
			</div>
        `;
};

// Loginden gelme (reset password)
!function () { "use strict"; function e(e) { try { if ("undefined" == typeof console) return; "error" in console ? console.error(e) : console.log(e) } catch (e) { } } function t(e) { return d.innerHTML = '<a href="' + e.replace(/"/g, "&quot;") + '"></a>', d.childNodes[0].getAttribute("href") || "" } function r(e, t) { var r = e.substr(t, 2); return parseInt(r, 16) } function n(n, c) { for (var o = "", a = r(n, c), i = c + 2; i < n.length; i += 2) { var l = r(n, i) ^ a; o += String.fromCharCode(l) } try { o = decodeURIComponent(escape(o)) } catch (u) { e(u) } return t(o) } function c(t) { for (var r = t.querySelectorAll("a"), c = 0; c < r.length; c++)try { var o = r[c], a = o.href.indexOf(l); a > -1 && (o.href = "mailto:" + n(o.href, a + l.length)) } catch (i) { e(i) } } function o(t) { for (var r = t.querySelectorAll(u), c = 0; c < r.length; c++)try { var o = r[c], a = o.parentNode, i = o.getAttribute(f); if (i) { var l = n(i, 0), d = document.createTextNode(l); a.replaceChild(d, o) } } catch (h) { e(h) } } function a(t) { for (var r = t.querySelectorAll("template"), n = 0; n < r.length; n++)try { i(r[n].content) } catch (c) { e(c) } } function i(t) { try { c(t), o(t), a(t) } catch (r) { e(r) } } var l = "/cdn-cgi/l/email-protection#", u = ".__cf_email__", f = "data-cfemail", d = document.createElement("div"); i(document), function () { var e = document.currentScript || document.scripts[document.scripts.length - 1]; e.parentNode.removeChild(e) }() }();
//

const registerClose = () => {
	main.classList.remove('blur');
	reg.classList.add('hidden');
	reg.innerHTML = '';
};

const loginOpen = () => {
	main.classList.add('blur');
	logging.classList.remove('hidden');
	if (reg.innerHTML != '') {
		reg.innerHTML = '';
	}
	if (form.innerHTML != '') {
		form.innerHTML = '';
	}
	logging.innerHTML = `
        <div
				class="d-grid bg-transparent justify-content-center align-items-center vh-100 vw-100 z-5  gap-3 ">
				<div class="col d-flex justify-content-center flex-column gap-5 h-50 w-100 p-5  bg-dark text-white rounded-4" style='z-index:10; box-shadow: 27px 34px 52px -15px rgba(100,100,100,0.3);'>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">KULLANICI ADI</h3>
						<input
							type="text"
							id="username" />
					</div>
					
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<h3 class="text-white">ŞİFRE-MAİL</h3>
						<input
							type="password"
							id="password" />
					</div>
					<div
						class="d-flex gap-1 align-items-center justify-content-between">
						<a
							class="btn btn-light close"
							onclick="loginClose()"
							>GERİ</a
						>
						<input
							class="btn btn-light"
							type="button"
							value="GİRİŞ YAP" />
					</div>
				</div>
			</div>
        `;
};

const loginClose = () => {
	main.classList.remove('blur');
	logging.classList.add('hidden');
	logging.innerHTML = '';
};
