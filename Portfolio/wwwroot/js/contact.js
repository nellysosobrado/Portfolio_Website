import { init, sendForm } from 'https://esm.sh/@emailjs/browser';

document.addEventListener("DOMContentLoaded", function () {
    const form = document.getElementById("contact-form");
    const feedback = document.getElementById("feedback");

    init("5BI2ufCTlowWv5WYV"); 

    form?.addEventListener("submit", function (e) {
        e.preventDefault();

        sendForm("service_9ywql0r", "template_qg78ql5", form)
            .then(() => {
                feedback.style.display = "block";
                form.reset();
            })
            .catch((error) => {
                alert("Fel: " + JSON.stringify(error));
            });
    });
});
