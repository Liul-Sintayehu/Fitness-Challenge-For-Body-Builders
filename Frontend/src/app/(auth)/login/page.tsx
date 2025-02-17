import LoginForm from "./components/LoginPage";

export default function LoginPage() {
  return (
    <div className="flex min-h-svh flex-col items-center justify-center bg-muted   md:p-10">
      <div className="w-full max-w-sm md:max-w-3xl -mt-20 h-fit">
        <LoginForm />
      </div>
    </div>
  );
}
