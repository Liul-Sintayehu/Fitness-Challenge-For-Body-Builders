import * as React from "react";
import {
  Select,
  SelectContent,
  SelectGroup,
  SelectItem,
  SelectLabel,
  SelectTrigger,
  SelectValue,
} from "@/components/ui/select";

interface EnumSelectProps {
  enumFile: Record<string, string>;
  placeholder?: string;
  value?: string;
  onChange: (value: string) => void;
  label?: string;
}

export function EnumSelect({
  enumFile,
  placeholder = "Select an option",
  value,
  onChange,
  label,
}: EnumSelectProps) {
  return (
    <Select value={value} onValueChange={onChange}>
      <SelectTrigger className="w-[180px]">
        <SelectValue placeholder={placeholder} />
      </SelectTrigger>
      <SelectContent>
        <SelectGroup>
          {label && <SelectLabel>{label}</SelectLabel>}
          {Object.entries(enumFile).map(([key, val]) => (
            <SelectItem key={key} value={val}>
              {val}
            </SelectItem>
          ))}
        </SelectGroup>
      </SelectContent>
    </Select>
  );
}
