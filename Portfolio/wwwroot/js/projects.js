
document.addEventListener("DOMContentLoaded", () => {
    const container = document.getElementById("project-list");

    const isLocalhost = window.location.hostname === "localhost";
    const apiBaseUrl = isLocalhost
        ? "https://localhost:5001"
        : "https://portfolioapi20250517155004-a3abhtfaecf6ekdh.swedencentral-01.azurewebsites.net";

    fetch(`${apiBaseUrl}/api/projects`)
        .then(response => {
            if (!response.ok) throw new Error("ERROR with API.");
            return response.json();
        })
        .then(projects => {
            container.innerHTML = "";
            projects.forEach(project => {
                const card = document.createElement("div");
                card.className = "project-card";
                card.innerHTML = `
                    <div class="project-image">
                        <img src="${project.imageUrl}" alt="${project.name}" />
                    </div>
                    <div class="project-details">
                        <h3>${project.name}</h3>
                        <div class="tech-used">
                            ${project.techStack.split(',').map(t => `<span class="tech">${t.trim()}</span>`).join('')}
                        </div>
                        <p class="project-desc">${project.description}</p>
                        <div class="project-actions">
                            ${project.githubUrl ? `<a href="${project.githubUrl}" class="btn-code" target="_blank"><i class="fab fa-github"></i> View Code</a>` : ""}
                            ${project.liveDemoUrl ? `<a href="${project.liveDemoUrl}" class="btn btn-demo" target="_blank"><i class="fas fa-external-link-alt"></i> Live Demo</a>` : ""}
                        </div>
                    </div>
                `;
                container.appendChild(card);
            });
        })
        .catch(error => {
            console.error("something happened when fetching for project:", error);
            container.innerHTML = `<p class="text-red-600">Cannot display any projects at the moment.</p>`;
        });
});
