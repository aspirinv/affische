<script lang="ts">
    import { post } from "../../tools/utils";

    
    let login:string = "";
    let pass:string = "";
    const auth = async ()=>{
        const token = await post<string, any>("api/auth", { 'login': login, 'password': pass});
        if(token){
            localStorage.setItem("auth_token", token.token);
            window.location.href = "/";
        }
    }
</script>


<div class="row justify-content-center">
    <div class="col-12 col-md-6 offset-md-3">
        <div class="card mt-5">
            <div class="card-body">
                <h3 class="card-title text-center">Login</h3>
                <div class="mb-3">
                    <label for="username" class="form-label">Username</label>
                    <input bind:value="{login}" type="text" class="form-control" id="username" placeholder="Enter your username" required>
                </div>
                <div class="mb-3">
                    <label for="password" class="form-label">Password</label>
                    <input bind:value="{pass}" type="password" class="form-control" id="password" placeholder="Enter your password" required>
                </div>
                <button type="submit" class="btn btn-primary w-100" on:click="{auth}">Login</button>
            </div>
        </div>
    </div>
</div>